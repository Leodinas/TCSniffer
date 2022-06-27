using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSniffer.utils
{
    public class FileUtil
    {
        public static string ReadString(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
    
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            return Encoding.UTF8.GetString(buffer);
        }

        public static void WriteString(string filename, string content)
        {
             FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            byte[] buf = Encoding.UTF8.GetBytes(content);
            fs.Write(buf, 0, buf.Length);
        }
    }
}
