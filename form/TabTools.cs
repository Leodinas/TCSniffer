using DotNetty.Buffers;
using DotNetty.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCSniffer.common;
using TCSniffer.utils;

namespace TCSniffer.form
{
    [attributes.CustomEvent(nameof(TabTools))]
    public class TabTools : ICustomControlEvents
    {
        private static Form1 frm => Form1.Form;

        public void Register()
        {
            frm.button_readKey.Click += Button_readKey_onClick;
            frm.button_saveKey.Click += Button_saveKey_onClick;
            frm.btn_tool_md5_calc.Click += Btn_tool_md5_calc_Click;
            frm.btn_tool_md5_copy_once.Click += Btn_tool_md5_copy_once_Click;
            frm.btn_tool_qqencrypt_calc.Click += Btn_tool_qqencrypt_calc_Click;
            frm.btn_tool_qqencrypt_copy.Click += Btn_tool_qqencrypt_copy_Click;
    
        }


        private void Button_readKey_onClick(object sender, EventArgs e)
        {
            List<DecryptionKey> keys = Common.GetTeaKeyLogSetList();
            string text = string.Empty;
            keys.ForEach(k => text += k.Key + Environment.NewLine);
            frm.textBox_keys.Text = text;
        }

        private void Button_saveKey_onClick(object sender, EventArgs e)
        {
            string keys_text = frm.textBox_keys.Text;
            string[] keys = keys_text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> key_set = new HashSet<string>();
            Common.Keys.Clear();
            keys.ToList().ForEach(k => key_set.Add(k));
            key_set.ToList().ForEach(k => Common.Keys.AddLast(new DecryptionKey() { Key = k, KeyType = KeyType.CUSTOM_KEY }));

        }

        #region MD5计算
        private void Btn_tool_md5_calc_Click(object sender, EventArgs e)
        {
            frm.txt_tool_md5_once.Text = frm.txt_tool_md5_input.Text.Md5().HexDump(); ;
        }

        private void Btn_tool_md5_copy_once_Click(object sender, EventArgs e)
        {
            string ret = frm.txt_tool_md5_once.Text;
            if (!string.IsNullOrEmpty(ret))
            {
                Clipboard.SetText(frm.txt_tool_md5_once.Text);
            }
        }
        #endregion

        #region QQ密码加密
        private void Btn_tool_qqencrypt_calc_Click(object sender, EventArgs e)
        {
            string qq = frm.txt_tool_qqencrypt_qq.Text;
            string pass = frm.txt_tool_qqencrypt_pass.Text;
            var buf = Unpooled.Buffer();
            try
            {
                buf.WriteBytes(MixUtil.GenerateMD5Byte(pass))
                .WriteInt(0)
                .WriteInt((int)Convert.ToInt64(qq));

                frm.txt_tool_qqencrypt_ret.Text = buf.Copy().Array.Md5().HexDump();
            }
            catch (Exception ex)
            {
                Toast.Warn(ex.Message);
            }
            finally
            {
                ReferenceCountUtil.Release(buf);
            }
        }

        private void Btn_tool_qqencrypt_copy_Click(object sender, EventArgs e)
        {
            string ret = frm.txt_tool_qqencrypt_ret.Text;
            if (!string.IsNullOrEmpty(ret))
            {
                Clipboard.SetText(frm.txt_tool_qqencrypt_ret.Text);
            }
        }
        #endregion


    }
}
