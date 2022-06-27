using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCSniffer.common;
using TCSniffer.component;
using TCSniffer.utils;

namespace TCSniffer.form.menu
{
    [attributes.CustomEvent(nameof(CtxMenuAnalysisTools))]
    public class CtxMenuPackets : ICustomControlEvents
    {
        
        private static Form1 Frm => Form1.Form;

        public void Register()
        {
            Frm.复制选中载荷ToolStripMenuItem.Click += CopyChoosePayload_Click;
            Frm.复制全部载荷ToolStripMenuItem.Click += CopyWholePayload_Click;
            Frm.读取抓包记录ToolStripMenuItem.Click += ReadCapturePacketsLogs_Click;
            Frm.保存抓包记录ToolStripMenuItem.Click += SaveCapturePacketsLogs_Click;
        }

        #region ctxMenuPackets
        private void CopyChoosePayload_Click(object sender, EventArgs e)
        {
            if (Frm.listView_package.SelectedItems.Count == 1)
            {
                string copied_payload = Frm.listView_package.SelectedItems[0].SubItems[6].Text;
                if (!string.IsNullOrEmpty(copied_payload))
                {
                    Clipboard.SetText(copied_payload);
                }
            }
        }

        private void CopyWholePayload_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in Frm.listView_package.Items)
            {
                if (item.Tag is PacketAnalyzer packet)
                {
                    sb.Append(packet.HexPayload);
                }
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                Clipboard.SetText(sb.ToString());
            }
        }

        private void ReadCapturePacketsLogs_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Title = "请选择抓包记录文件",
                InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data"),
                Filter = "所有文件(*.*)|*.*|文本文件(*.txt)|*.txt"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                DisplayPacketLogListView(FileUtil.ReadString(file.FileName));
            }
        }

        private void SaveCapturePacketsLogs_Click(object sender, EventArgs e)
        {
            StringBuilder sb_all = new StringBuilder();
            foreach (ListViewItem item in Frm.listView_package.Items)
            {
                string index = item.SubItems[0].Text;
                string orientation = item.SubItems[1].Text;
                string src = item.SubItems[2].Text;
                string dest = item.SubItems[3].Text;
                string capture_time = item.SubItems[4].Text;
                string payload_len = item.SubItems[5].Text;
                string payload = string.Empty;
                if (item.Tag is PacketAnalyzer analysisPacket)
                {
                    payload = analysisPacket.HexPayload;
                }
                //index orientation src dest capture_time payload_len payload
                string row = $"{index}---{orientation}---{src}---{dest}---{capture_time}---{payload_len}---{payload}";
                sb_all.Append(row).AppendLine();
            }
            if (string.IsNullOrEmpty(sb_all.ToString())) return;
            AppendTeaKeyLog(sb_all);
            if (!Directory.Exists("data")) Directory.CreateDirectory("data");
            string capture_log_filename = $"data/capture_log-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.txt";
            FileUtil.WriteString(capture_log_filename, sb_all.ToString());
        }

        private void DisplayPacketLogListView(string data)
        {
            Frm.listView_package.Items.Clear();

            string[] rows = data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<ListViewItem> lvs = new List<ListViewItem>();
            rows.ToList().ForEach(row =>
            {
                string[] col = row.Split("---".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (col.Length == 7)
                {
                    string index = col[0];
                    string orientation = col[1];
                    string src = col[2];
                    string dest = col[3];
                    string capture_time = col[4];
                    string payload_len = col[5];
                    string payload = col[6];
                    lvs.Add(new ListViewItem()
                    {
                        Text = index,
                        SubItems =
                        {
                            orientation,
                            src,
                            dest,
                            capture_time,
                            payload_len,
                            payload
                        },
                        Tag = new PacketAnalyzer() { HexPayload = payload, CaptureTime = capture_time },
                        ForeColor = (orientation == "Send") ? Color.Red : Color.Blue,
                    });
                }
                else if (col.Length == 4)
                {
                    DecryptionKey key = new DecryptionKey()
                    {
                        Key = col[0],
                        KeyType = (KeyType)Enum.Parse(typeof(KeyType), col[1]),
                        PrivateKey = col[2],
                        PublicKey = col[3]
                    };
                    Common.Keys.AddLast(key);
                }
            });

            Frm.listView_package.Items.AddRange(lvs.ToArray());
        }

        private void AppendTeaKeyLog(StringBuilder sb)
        {
            List<DecryptionKey> keys = Common.GetTeaKeyLogSetList();
            keys.ToList()
                .ForEach(k =>
                {
                    string pri_key = string.IsNullOrEmpty(k.PrivateKey) ? "placeholder" : k.PrivateKey;
                    string pub_key = string.IsNullOrEmpty(k.PublicKey) ? "placeholder" : k.PublicKey;
                    sb.Append($"{k.Key}---{k.KeyType}---{pub_key}---{pri_key}").AppendLine();
                });
        }
        #endregion
    }
}
