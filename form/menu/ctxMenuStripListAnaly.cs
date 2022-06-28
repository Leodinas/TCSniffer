using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCSniffer.common;
using TCSniffer.component;

namespace TCSniffer.form.menu
{
    [attributes.CustomEvent(nameof(ctxMenuStripListAnaly))]
    public partial class ctxMenuStripListAnaly : ICustomControlEvents
    {


        private static Form1 Frm => Form1.Form;

        public void Register()
        {
            Frm.复制载荷数据ToolStripMenuItem.Click += 复制载荷数据ToolStripMenuItemOnClick;
            Frm.复制解析数据ToolStripMenuItem.Click += 复制解析数据ToolStripMenuItemOnClick;
            Frm.复制PBJCE数据ToolStripMenuItem.Click += 复制PBJCE数据ToolStripMenuItemOnClick;
            Frm.复制ServiceCmdToolStripMenuItem.Click += 复制ServiceCmdToolStripMenuItemOnClick;
            Frm.清空数据ToolStripMenuItem.Click += 清空数据ToolStripMenuItemOnClick;
            Frm.解析PB数据ToolStripMenuItem.Click += 解析PB数据ToolStripMenuItemOnClick;
            Frm.解析JCE数据ToolStripMenuItem.Click += 解析Jce数据ToolStripMenuItemOnClick;
            Frm.分析ToolStripMenuItem.Click += 分析ToolStripMenuItemOnClick;
        }

        private void 分析ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            InvokeClick(Frm.button_analy);
        }

        private void InvokeClick(Button button)
        {
            Type type = button.GetType();
            object[] o = new object[1];
            MethodInfo m = type.GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
            o[0] = EventArgs.Empty;
            m.Invoke(button, o);
            return;
        }

        private void CloneTree()
        {
            Frm.treeView_analy.Nodes.Clear();
            foreach (TreeNode node in Frm.TreeView1.Nodes)
            {
                TreeNode newNode = node.Clone() as TreeNode;
                Frm.treeView_analy.Nodes.Add(newNode);
            }
            Frm.treeView_analy.ExpandAll();

        }
        private void 解析Jce数据ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            if (Frm.listView_analysis.SelectedItems.Count == 1)
            {
                if (Frm.listView_analysis.SelectedItems[0].Tag is PacketAnalyzer pkg)
                {
                    //Clipboard.SetText(pkg.PbJcePayload);
                    Frm.RichTextBox1.Text = pkg.PbJcePayload;
                    InvokeClick(Frm.button_reverseJce);
                    CloneTree();



                }
            }
        }

        private void 解析PB数据ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            if (Frm.listView_analysis.SelectedItems.Count == 1)
            {
                if (Frm.listView_analysis.SelectedItems[0].Tag is PacketAnalyzer pkg)
                {
                    //Clipboard.SetText(pkg.PbJcePayload);

                    Frm.RichTextBox1.Text = pkg.PbJcePayload;
                    InvokeClick(Frm.button_reversePb);
                    CloneTree();
                }
            }
        }

        private void 复制ServiceCmdToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            if (Frm.listView_analysis.SelectedItems.Count == 1)
            {
                if (Frm.listView_analysis.SelectedItems[0].Tag is PacketAnalyzer pkg)
                {
                    Clipboard.SetText(pkg.ServiceCmd);
                }
            }
        }

        private void 复制PBJCE数据ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            if (Frm.listView_analysis.SelectedItems.Count == 1)
            {
                if (Frm.listView_analysis.SelectedItems[0].Tag is PacketAnalyzer pkg)
                {
                    Clipboard.SetText(pkg.PbJcePayload);
                }
            }
        }

        private void 复制解析数据ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            if (Frm.listView_analysis.SelectedItems.Count == 1)
            {
                if (Frm.listView_analysis.SelectedItems[0].Tag is PacketAnalyzer pkg)
                {
                    Clipboard.SetText(pkg.ParsePayload);
                }
            }
        }

        private void 复制载荷数据ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            if (Frm.listView_analysis.SelectedItems.Count == 1)
            {
                if (Frm.listView_analysis.SelectedItems[0].Tag is PacketAnalyzer pkg)
                {
                    Clipboard.SetText(pkg.HexPayload);
                }
            }
        }

        private void 清空数据ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            Frm.listView_analysis.Items.Clear();
        }
    }
}
