using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.common;

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


    }
}
