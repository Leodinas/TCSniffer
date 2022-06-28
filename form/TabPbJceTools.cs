using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TCSniffer.common;
using TCSniffer.PbJceParse;
using TCSniffer.utils;


namespace TCSniffer.form
{
    [attributes.CustomEvent(nameof(TabPbJceTools))]
    public class TabPbJceTools : ICustomControlEvents
    {
        private static Form1 Frm => Form1.Form;

        public void Register()
        {
            Frm.button_reverseJce.Click += button_reverseJce;
            Frm.button_reversePb.Click += button_reversePb;

        }

        private void button_reversePb(object sender, EventArgs e)
        {

            Frm.button_reversePb.Text = "解析中";
            Frm.button_reversePb.Enabled = false;

            Frm.TreeView1.Nodes.Clear();
            var BytesIn = HexUtil.HexStrToByteArray(Frm.RichTextBox1.Text.Replace(" ", "").Trim());
            if (BytesIn != null)
            {
                ProtoBuff.TreeNodeStruct NodeStruct = new ProtoBuff.TreeNodeStruct();
                NodeStruct.NodeList = new List<TreeNode>();
                NodeStruct.parentNode = new TreeNode("PB");
                NodeStruct.NodeList.Add(NodeStruct.parentNode);
                Frm.TreeView1.Nodes.Clear();
                NodeStruct = ProtoBuff.QuickDecodeProto(BytesIn, "", NodeStruct);
                Frm.TreeView1.Nodes.AddRange(NodeStruct.NodeList.ToArray());
                Frm.TreeView1.ExpandAll();
            }
            Frm.button_reversePb.Enabled = true;
            Frm.button_reversePb.Text = "PB解析";
        }

        private void button_reverseJce(object sender, EventArgs e)
        {

            Frm.button_reverseJce.Text = "解析中";
            Frm.button_reverseJce.Enabled = false;

            Frm.TreeView1.Nodes.Clear();
            var BytesIn = HexUtil.HexStrToByteArray(Frm.RichTextBox1.Text.Replace(" ", "").Trim());
            if (BytesIn != null)
            {
                JceStruct.MapCount = new List<int>();
                JceStruct.MapCount.Add(0);
                JceStruct.ListCount = new List<int>();
                JceStruct.ListCount.Add(0);
                JceStruct.TreeNodeStruct NodeStruct = new JceStruct.TreeNodeStruct();
                NodeStruct.NodeList = new List<TreeNode>();
                NodeStruct.CurrentNode = new TreeNode("JCE");
                NodeStruct.NodeList.Add(NodeStruct.CurrentNode);
                NodeStruct.BytesIn = BytesIn;
                NodeStruct = JceStruct.QuickDecodeJce("", NodeStruct);
                Frm.TreeView1.Nodes.AddRange(NodeStruct.NodeList.ToArray());
                Frm.TreeView1.ExpandAll();

            }
            Frm.button_reverseJce.Enabled = true;
            Frm.button_reverseJce.Text = "Jce解析";

        }
    }
}
