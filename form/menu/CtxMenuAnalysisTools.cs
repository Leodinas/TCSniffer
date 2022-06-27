using System;
using System.Text;
using TCSniffer.common;
using DotNetty.Buffers;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TCSniffer.utils;
using TCSniffer.attributes;

namespace TCSniffer.form.menu
{
    [attributes.CustomEvent(nameof(CtxMenuAnalysisTools))]
    public class CtxMenuAnalysisTools : ICustomControlEvents

    {
        private static Form1 Frm => Form1.Form;
        public void Register()
        {
            Frm.计算字节数ToolStripMenuItem.Click += 计算字节数ToolStripMenuItem_Click;
            Frm.TLV格式化ToolStripMenuItem.Click += TLV格式化ToolStripMenuItem_Click;
            //Frm.选中字节计算换行ToolStripMenuItem.Click += 选中字节计算换行ToolStripMenuItem_Click;
            //Frm.一键格式化ToolStripMenuItem.Click += 一键格式化ToolStripMenuItem_Click;

            Frm.十六个0ToolStripMenuItem.Click += 十六个0ToolStripMenuItem_Click;
            Frm.KEY日志ToolStripMenuItem.Click += KEY日志ToolStripMenuItem_Click;

            Frm.kEY逐日志ToolStripMenuItem.Click += KEY日志逐字节ToolStripMenuItem_Click;
            Frm.到10进制ToolStripMenuItem.Click += 到10进制ToolStripMenuItem1_Click;
            Frm.到文本ToolStripMenuItem.Click += 到文本ToolStripMenuItem_Click;
            Frm.到QQToolStripMenuItem.Click += 到QQToolStripMenuItem_Click;
            Frm.dec到时间ToolStripMenuItem.Click += Dec到时间ToolStripMenuItem_Click;
            Frm.hex到时间ToolStripMenuItem.Click += Hex到时间ToolStripMenuItem_Click;
            Frm.hex到IPToolStripMenuItem.Click += Hex到IPToolStripMenuItem_Click;
            Frm.解压数据ToolStripMenuItem.Click += Inflater解压ToolStripMenuItem_Click;
        }



        #region 计算字节数
        private void 计算字节数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            if (selected_text.Length % 2 != 0)
            {
                Toast.Warn("请选择完整字节");
                return;
            }
            if (!Regex.IsMatch(selected_text, "^[0-9a-fA-F]+$"))
            {
                Toast.Warn("字节数据不合法");
                return;
            }
            Toast.Info((selected_text.Length / 2).ToString());
        }
        #endregion

        #region TLV 格式化
        private void TLV格式化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                var buf = Unpooled.WrappedBuffer(selected_text.DecodeHex());
                string ret = new TLVParser.TLVFormatter().Parse(buf);
                Frm.Log($"\n{ret}\n");
                Console.WriteLine(ret);
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        #endregion



        #region TEA解密 右键菜单

        private void 十六个0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                byte[] key = new byte[16];
                byte[] data = Frm.r_txt_log.SelectedText.DecodeHex();
                byte[] ret = Tea.Decrypt(data, key);
                if (ret != null)
                {
                    Frm.Log("\r\n" + ret.HexDump());
                }
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }

        }

        private void KEY日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string encrypt_data = Frm.r_txt_log.SelectedText.ClearSpecialSymbols(); 
            if (string.IsNullOrEmpty(encrypt_data)) return;
            byte[] data = encrypt_data.DecodeHex();
            byte[] decrypt_data = Common.TeaKeyLogDecrypt(data, out DecryptionKey decryptionKey);
            if (decrypt_data != null)
            {
                Frm.Log("\r\n [key = " + decryptionKey.Key + "\r\n " + decrypt_data.HexDump() + "\r\n  ]");

            }


        }

        private void KEY日志逐字节ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string encrypt_data = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(encrypt_data)) return;
            for (int i = 0; i < encrypt_data.Length; i += 2)
            {
                byte[] data = encrypt_data.Substring(i, encrypt_data.Length - i).DecodeHex();
                byte[] decrypt_data = Common.TeaKeyLogDecrypt(data, out DecryptionKey decryptionKey);
                if (decrypt_data != null)
                {
                    Frm.Log("\r\n [key = " + decryptionKey.Key + "\r\n " + decrypt_data.HexDump() + "\r\n  ]");
                    Toast.Info($"逐字节KEY日志解密成功, 共读取了[{i}]个字节长度");
                    return;
                }
            }
            Toast.Info("逐字节KEY日志解密失败, 未找到匹配的数据");
        }

        #endregion

        #region 右键菜单 转换
        private void 到10进制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                string str = $" //[Dec: {selected_text.HexToDec()}]";
                Frm.Log(str);
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }
        }
        private void 到文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                string str = $" //[Text: {selected_text.DecodeHex().HexToString(Encoding.UTF8)}]";
                Console.WriteLine(str);
                Frm.Log(str);
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }
        }

        private void 到QQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                string ret = $" //[QQ: {selected_text.HexToDec()}]";
                Frm.Log(ret);
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }
        }

        private void Dec到时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                Frm.Log($" //[Time: {double.Parse(selected_text).UnixTimeStampToDateTime()}]");
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }
        }

        private void Hex到时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                string ret = $" //[Time: {selected_text.HexToDateTime()}]";
                Frm.Log(ret);
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }
        }

        private void Hex到IPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.SelectedText.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;
            try
            {
                Frm.Log($" //[Ip: {selected_text.HexToDec().LongToIpEndian()}]");
            }
            catch (Exception ex)
            {
                Toast.Failed(ex.Message);
            }
        }

        private void Inflater解压ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected_text = Frm.r_txt_log.Text.ClearSpecialSymbols();
            if (string.IsNullOrEmpty(selected_text)) return;

            try
            {
                MemoryStream memoryStream = new MemoryStream(selected_text.DecodeHex());

                DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress);
                MemoryStream outputStream = new MemoryStream();

                deflateStream.CopyTo(outputStream);
                Frm.Log($"\n\n[{outputStream.ToArray().HexDump()}]\n\n");

            }
            catch (Exception)
            {
                // ignored
            }
        }
        #endregion


    }
}
