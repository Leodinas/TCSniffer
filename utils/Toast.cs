using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCSniffer.extension;

/**
 * 
 * use https://github.com/yggo/androidqq-sniffer/blob/main/Utils/Toast.cs
 * 
 */



namespace TCSniffer.utils
{
    class Toast
    {
        public static void Success(string text, string caption = "提示")
        {

            MessageBoxEx.Show(Form1.Form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void Failed(string text, string caption = "提示")
        {
            MessageBoxEx.Show(Form1.Form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warn(string text, string caption = "提示")
        {
            MessageBoxEx.Show(Form1.Form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Info(string text, string caption = "提示")
        {
            MessageBoxEx.Show(Form1.Form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
