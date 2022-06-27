using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DotNetty.Buffers;
using SharpPcap;
using SharpPcap.LibPcap;
using TCSniffer.common;
using TCSniffer.component;
using TCSniffer.utils;

namespace TCSniffer
{
    public partial class Form1 : Form
    {

        public static Form1 Form { get; private set; }
        public ICaptureDevice Device { get; set; } // 当前网卡设备

        private string SelectedDeviceIpAddr { get; set; }// 当前网卡设备

        private RealTimePacketsAnalyzer RealTimePacketsAnalyzer { get; } = new RealTimePacketsAnalyzer();//数据包分析


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Form = this;
            LoadDevices();
            RegCustomEvents();
            OptimizeListView();
            listView_package.ContextMenuStrip = ctxMenuStrip_packets;
            r_txt_log.ContextMenuStrip = ctxMenuStrip_analysis_tools;
            listView_analysis.ContextMenuStrip = ctxMenuStrip_trace_flow;
        }

        private void OptimizeListView()
        {
            listView_package
              .GetType()
              .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
              ?.SetValue(listView_package, true, null);
            listView_analysis
                .GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(listView_analysis, true, null);
        }

        private void RegCustomEvents()
        {

            Type[] types = typeof(attributes.CustomEvent).GetExportedTypes().Where(
                o => IsCustomEventAttrbute(Attribute.GetCustomAttributes(o, false))).ToArray();
            foreach (Type type in types)
            {
                if (type.GetInterface(nameof(ICustomControlEvents)) != null)
                {
                    var clazz = (ICustomControlEvents)type.Assembly.CreateInstance(type.FullName);
                    clazz.Register();
                }
            }
        }

        private static bool IsCustomEventAttrbute(Attribute[] o)
        {
            foreach (Attribute a in o)
            {
                if (a is attributes.CustomEvent)
                    return true;
            }
            return false;
        }




        public void ThreadSafeUpdate(Action action)
        {
            Invoke(action);
        }


        private void LoadDevices()
        {
            new Thread(() =>
            {
                try
                {
                    ThreadSafeUpdate(() => comboBox_devices.Enabled = false);
                    ThreadSafeUpdate(() => button_loadDevices.Enabled = false);
                    ThreadSafeUpdate(() => button_loadDevices.Text = "读取中");

                    if (Device != null)
                    {
                        CaptureDeviceList.Instance.Refresh();
                        return;
                    }
                    ThreadSafeUpdate(() => comboBox_devices.Items.Clear());
                    foreach (PcapDevice device in CaptureDeviceList.Instance)
                    {
                        ThreadSafeUpdate(() =>
                        comboBox_devices.Items.Add(new DeviceItem()
                        { Device = device }));
                    }

                }
                catch (Exception ex)
                {
                    Toast.Failed(ex.Message);
                }
                finally
                {
                    ThreadSafeUpdate(() =>
                    {
                        button_loadDevices.Enabled = true;
                        button_loadDevices.Text = "读取网卡";
                        comboBox_devices.Enabled = true;
                        if (comboBox_devices.Items.Count > 0)
                        {
                            comboBox_devices.SelectedIndex = 0;
                        }
                    });
                }
            }).Start();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Device == null || Device.Started) return;
                listView_package.Items.Clear();
                Device.Open(DeviceMode.Normal, 1000);
                Device.Filter = "tcp port 8080 or tcp port 14000 or tcp port 443";
                //Device.Filter = "tcp";
                Device.OnPacketArrival += Device_OnPacketArrival;
                Device.StartCapture();
                RealTimePacketsAnalyzer.StartAnalysisThread();
                ThreadSafeUpdate(() => button_startCapt.Enabled = false);
                Toast.Success("操作成功");

            }
            catch (Exception)
            {
                Toast.Failed("内部发生异常");
            }


        }

        private void Device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var captureTime = e.Packet.Timeval.Date.ToLocalTime();
            var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            var tcpPacket = packet.Extract<PacketDotNet.TcpPacket>();
            //Debug.WriteLine("captureTime:" + captureTime);
            if (tcpPacket != null)
            {
                RealTimePacketsAnalyzer.ProcessPackets(tcpPacket);
            }
        }

        private void ComboBox_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Device = CaptureDeviceList.Instance[comboBox_devices.SelectedIndex];
            SelectedDeviceIpAddr = ((DeviceItem)comboBox_devices.SelectedItem).IpAddr;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView_package.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Device != null)
            {
                try
                {
                    Device.OnPacketArrival -= Device_OnPacketArrival;
                    Device.StopCapture();
                    Device.Close();
                    ThreadSafeUpdate(() => button_startCapt.Enabled = true);
                    Toast.Success("操作成功");

                }
                catch (Exception)
                {
                    Toast.Failed("内部发生异常");
                }
            }
            else
            {
                Toast.Info("当前无网卡处于捕捉状态");
            }
        }

        private void button_loadDevices_Click_1(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void button_analy_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("---------");
            List<PacketAnalyzer> analysisPackets = new List<PacketAnalyzer>();
            ListViewItem[] currentItems = new ListViewItem[listView_package.Items.Count];
            listView_package.Items.CopyTo(currentItems, 0);
            listView_analysis.Items.Clear();


            foreach (ListViewItem item in currentItems)
            {
                string captureTime = item.SubItems[4].Text;
                byte[] payload = item.SubItems[6].Text.DecodeHex();
                IByteBuffer buffer = Unpooled.WrappedBuffer(payload);
                if (RealTimePacketsAnalyzer.IsAndroidQQProtocol(buffer))
                {
                    int pkgLen = buffer.GetInt(buffer.ReaderIndex);
                    byte[] pkgPayload = new byte[pkgLen];
                    if (buffer.ReadableBytes >= pkgPayload.Length)
                    {
                        buffer.ReadBytes(pkgPayload, 0, pkgPayload.Length);
                        analysisPackets.Add(new PacketAnalyzer()
                        {
                            Payload = payload,
                            CaptureTime = captureTime,
                            HexPayload = item.SubItems[6].Text,

                        });
                    }
                }
            }

            foreach (PacketAnalyzer item in analysisPackets)
            {
                try
                {
                    item.Deserialize();
                    var lvi = new ListViewItem
                    {
                        Text = item.Orientation,
                        SubItems =
                        {
                            item.ServiceCmd,
                            item.SSOReq,
                            item.Payload.Length.ToString(),
                            item.CaptureTime,
                            item.HexPayload,
                            item.ParsePayload,
                           item.PbJcePayload

                        },
                        Tag = item,
                        ForeColor = item.Orientation == "Send" ? Color.Red : Color.Blue
                    };
                    ThreadSafeUpdate(() => listView_analysis.Items.Add(lvi));
                }
                catch (Exception ex)
                {
                    //Toast.Failed(ex.Message);
                }
            }
        }

        public void Log(string text)
        {
            string old_text = Clipboard.GetText();
            int old_start = r_txt_log.SelectionStart;
            int old_length = r_txt_log.SelectionLength;
            r_txt_log.Select(old_start + old_length, 0);
            Clipboard.SetText(text);
            r_txt_log.Paste();
            Clipboard.SetText(old_text);
            r_txt_log.Select(old_start + old_length, 0);
        }
        public void Log(string text, params object[] args)
        {
            Log(string.Format(text, args));
        }

        private void lv_packet_log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
