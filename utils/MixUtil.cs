using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TCSniffer.utils
{
    public static class MixUtil
    {
        public static Type[] GetExportedTypes(this Type assembly)
        {
            return System.Reflection.Assembly.GetAssembly(assembly).GetExportedTypes();
        }

        public static string Md5(this string input)
        {
            MD5 mi = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            byte[] newBuffer = mi.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newBuffer.Length; i++)
            {
                sb.Append(newBuffer[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public static byte[] Md5(this byte[] input)
        {
            MD5 mi = MD5.Create();
            return mi.ComputeHash(input);
        }
        public static byte[] GenerateMD5Byte(this string input)
        {
            MD5 mi = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            byte[] newBuffer = mi.ComputeHash(buffer);
            return newBuffer;
        }
    }
}
