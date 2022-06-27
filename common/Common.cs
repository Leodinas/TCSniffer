using System.Collections.Generic;
using System.Linq;
using TCSniffer.extension;
using TCSniffer.utils;

namespace TCSniffer.common
{
    public enum KeyType
    {
        SHARE_KEY,
        ZERO_KEY,
        D2_KEY,
        RAND_TGT_KEY,
        CUSTOM_KEY,
        CACHED_SHAKEY,
    }
    public class DecryptionKey
    {
        public string Key { get; set; }
        public KeyType KeyType { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
    }

    
    public class Common
    {
        public static LinkedList<DecryptionKey> Keys { get; set; } = new LinkedList<DecryptionKey>();
        static Common()
        {
            Keys.AddLast(new DecryptionKey() { Key = new byte[16].HexDump(), KeyType = KeyType.ZERO_KEY });
        }

        public static List<DecryptionKey> GetTeaKeyLogSetList()
        {
            List<DecryptionKey> decryptionKeys = new List<DecryptionKey>();
            Keys.ToList().ForEach(k =>
            {
                if (decryptionKeys.Find(d => d.Key == k.Key) == null) decryptionKeys.Add(k);
            });
            return decryptionKeys;
        }

        public static byte[] TeaKeyLogDecrypt(byte[] In, out DecryptionKey decryptionKey)
        {
            decryptionKey = null;
            List<DecryptionKey> keys = Keys.ToList();
            foreach (DecryptionKey t in keys)
            {
                var d = Tea.Decrypt(In, t.Key.DecodeHex());
                if (d != null)
                {
                    decryptionKey = t;
                    return d;
                }
            }
            return null;
        }

       

    }




}
