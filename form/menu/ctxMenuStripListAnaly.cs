using System;
using System.Collections.Generic;
using System.Linq;
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
