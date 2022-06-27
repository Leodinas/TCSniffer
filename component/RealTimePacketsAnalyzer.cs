using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetty.Buffers;
using DotNetty.Common.Utilities;
using PacketDotNet;
using TCSniffer.utils;
using static System.Collections.StructuralComparisons;

namespace TCSniffer.component
{
    class RealTimePacketsAnalyzer
    {
        public string MatchedSrcIp { get; private set; }
        public string MatchedDstIp { get; private set; }
        public string MatchedSrcPort { get; private set; }
        public string MatchedDstPort { get; private set; }

        private IByteBuffer MatchedPayloadBuf { get; set; }

        private readonly byte[] ZERO_BYTES = { 0 };

        private static Form1 frm => Form1.Form;

        public void ProcessPackets(TcpPacket tcpPacket)
        {
            IPPacket ipPacket = (IPPacket)tcpPacket.ParentPacket;
            IPAddress srcIp = ipPacket.SourceAddress;
            IPAddress dstIp = ipPacket.DestinationAddress;
            int srcPort = tcpPacket.SourcePort;
            int dstPort = tcpPacket.DestinationPort;
            int length = ipPacket.TotalLength;
           // Debug.WriteLine(srcIp + "-" + dstIp+"-"+ length);
            if (tcpPacket.PayloadData.Length == 0 || tcpPacket.PayloadData == ZERO_BYTES) return;
           // AppendPacketLogItems("recv", null);

            if (MatchedDstIp == null)
            {
                //首次捕获
                IByteBuffer buf = Unpooled.WrappedBuffer(tcpPacket.PayloadData);
                try
                {
                    if (IsAndroidQQProtocol(buf))
                    {
                        MatchedPayloadBuf.WriteBytes(tcpPacket.PayloadData);
                        MatchedSrcIp = srcIp.ToString();
                        MatchedDstIp = dstIp.ToString();
                        MatchedSrcPort = srcPort.ToString();
                        MatchedDstPort = dstPort.ToString();
                        Debug.WriteLine(MatchedSrcIp);
                    }
                }
                finally
                {
                    buf.SafeRelease();
                }
            }
            else
            {
                if (srcIp.ToString() == MatchedDstIp || dstIp.ToString() == MatchedDstIp)
                {
                    MatchedPayloadBuf.WriteBytes(tcpPacket.PayloadData);
                }
            }
        }

        public void StartAnalysisThread()
        {
            MatchedPayloadBuf = Unpooled.Buffer();
            new Thread(() =>
            {
                while (frm.Device.Started)
                {
                    try
                    {
                        while (MatchedPayloadBuf.IsReadable())
                        {
                            if (IsAndroidQQProtocol(MatchedPayloadBuf))
                            {
                                string orientation = (MatchedPayloadBuf.GetInt(MatchedPayloadBuf.ReaderIndex + 9) == 0) ? "Recv" : "Send";
                                int pkg_len = MatchedPayloadBuf.GetInt(MatchedPayloadBuf.ReaderIndex);
                                byte[] pkg_payload = new byte[pkg_len];
                                if (MatchedPayloadBuf.ReadableBytes >= pkg_payload.Length)
                                {
                                    MatchedPayloadBuf.ReadBytes(pkg_payload, 0, pkg_payload.Length);
                                    AppendPacketLogItems(orientation, pkg_payload);
                                    MatchedPayloadBuf.DiscardReadBytes();
                                }


                            }
                            else if (MatchedPayloadBuf.ReadableBytes >= 9)
                            {
                                MatchedPayloadBuf.ReadBytes(9);
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    Thread.Sleep(1000);
                }
                //Logger.Info("The analysis thread has stopped.");
                MatchedSrcIp = null;
                MatchedDstIp = null;
                MatchedSrcPort = null;
                MatchedDstPort = null;
                MatchedPayloadBuf.SafeRelease();
            }).Start();
        }

        private void AppendPacketLogItems(string orientation, byte[] payload)
        {
            PacketLogLVI pl = new PacketLogLVI()
            {
                Index = (frm.listView_package.Items.Count + 1).ToString(),
                Orientation = orientation,

                CaptureTime = DateTime.Now.ToString(),
                PayloadLen = payload.Length.ToString(),
                PayloadData = payload.HexDump(),
                Tag = new PacketAnalyzer() { HexPayload = payload.HexDump() }
            };
            if (orientation == "Send")
            {
                pl.SrcIp = $"{MatchedSrcIp}:{MatchedSrcPort}";
                pl.DstIp = $"{MatchedDstIp}:{MatchedDstPort}";
            }
            else
            {
                pl.SrcIp = $"{MatchedDstIp}:{MatchedDstPort}";
                pl.DstIp = $"{MatchedSrcIp}:{MatchedSrcPort}";
            }

            frm.ThreadSafeUpdate(() =>
            {
                ListViewItem lv = pl.BuildLVI();
                lv.ForeColor = orientation == "Send" ? Color.Red : Color.Blue;
                frm.listView_package.Items.Add(lv);
            });
        }

        private readonly byte[] ANDROIDQQ_PROTOCOL_MARK1 = { 0x00, 0x00, 0x00, 0x0A, 0x00 };
        private readonly byte[] ANDROIDQQ_PROTOCOL_MARK2 = { 0x00, 0x00, 0x00, 0x0A, 0x01 };
        private readonly byte[] ANDROIDQQ_PROTOCOL_MARK3 = { 0x00, 0x00, 0x00, 0x0A, 0x02 };
        private readonly byte[] ANDROIDQQ_PROTOCOL_MARK4 = { 0x00, 0x00, 0x00, 0x0B, 0x00 };
        private readonly byte[] ANDROIDQQ_PROTOCOL_MARK5 = { 0x00, 0x00, 0x00, 0x0B, 0x01 };
        private readonly byte[] ANDROIDQQ_PROTOCOL_MARK6 = { 0x00, 0x00, 0x00, 0x0B, 0x02 };
        public bool IsAndroidQQProtocol(IByteBuffer buffer)
        {
          //  return true;
            if (buffer.ReadableBytes < 9) return false;
            byte[] tag = new byte[5];
            buffer.GetBytes(buffer.ReaderIndex + 4, tag, 0, 5);
            return ((IStructuralEquatable)tag).Equals(ANDROIDQQ_PROTOCOL_MARK1, StructuralEqualityComparer) ||
                   ((IStructuralEquatable)tag).Equals(ANDROIDQQ_PROTOCOL_MARK2, StructuralEqualityComparer) ||
                   ((IStructuralEquatable)tag).Equals(ANDROIDQQ_PROTOCOL_MARK3, StructuralEqualityComparer) ||
                   ((IStructuralEquatable)tag).Equals(ANDROIDQQ_PROTOCOL_MARK4, StructuralEqualityComparer) ||
                   ((IStructuralEquatable)tag).Equals(ANDROIDQQ_PROTOCOL_MARK5, StructuralEqualityComparer) ||
                   ((IStructuralEquatable)tag).Equals(ANDROIDQQ_PROTOCOL_MARK6, StructuralEqualityComparer);
        }
    }


}
