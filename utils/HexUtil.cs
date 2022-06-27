using DotNetty.Buffers;
using DotNetty.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TCSniffer.utils
{
    public static class HexUtil
    {
        public static string HexDump(this byte[] array) => HexDump(Unpooled.WrappedBuffer(array));
        public static string HexDump(this string hexStr) => HexDump(Unpooled.WrappedBuffer(hexStr.DecodeHex()));

        public static string HexDump(this IByteBuffer buffer)
        {
            if (buffer==null) return "";
            try
            {
                string hexStr = ByteBufferUtil.HexDump(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hexStr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sb.Append(hexStr, i, 2).Append(" ");
                    }
                }
                return sb.ToString().Trim().ToUpper();
            }
            finally
            {
                ReferenceCountUtil.Release(buffer);
            }
        }

        public static byte[] DecodeHex(this string hexStr)
        {
            if (string.IsNullOrEmpty(hexStr))
            {
                throw new ArgumentNullException("字节数据不能为空或null");
            }
            hexStr = hexStr.ClearSpecialSymbols();
            if ((hexStr.Length % 2) != 0)
            {
                hexStr += "";
            }
            if (!Regex.IsMatch(hexStr, "^[0-9a-fA-F]+$"))
            {
                throw new ArgumentException("非法的16进制字节数据");
            }
            byte[] returnBytes = new byte[hexStr.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexStr.Substring(i * 2, 2), 16);
            }
            return returnBytes;
        }



        public static string ClearSpecialSymbols(this string str)
        {
            return str.Replace(" ", "").Replace("\r", "").Replace("\n", "");
        }
        public static string HexPadLeft(this byte hex)
        {
            return Convert.ToString(hex, 16).PadLeft(2, '0');
        }
        public static string HexPadLeft(this short hex)
        {
            return Convert.ToString(hex, 16).PadLeft(4, '0');
        }
        public static string HexPadLeft(this uint hex)
        {
            return Convert.ToString(hex, 16).PadLeft(8, '0');
        }
        public static string HexPadLeft(this int hex)
        {
            return Convert.ToString(hex, 16).PadLeft(8, '0');
        }
        public static byte[] ReadRemainingBytes(this IByteBuffer buf)
        {
            byte[] ret = new byte[buf.ReadableBytes];
            buf.ReadBytes(ret, 0, buf.ReadableBytes);
            return ret;
        }


        public static DateTime UnixTimeStampToDateTime(this double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
        public static string HexToString(this byte[] hexArray, Encoding charset)
        {
            Encoding chs = Encoding.GetEncoding(charset.CodePage);
            return chs.GetString(hexArray);
        }
        public static long HexToDec(this string hexStr)
        {
            hexStr = hexStr.ClearSpecialSymbols();
            return Convert.ToInt64(hexStr, 16);
        }
        public static DateTime HexToDateTime(this string hexStr)
        {
            long timestamp = HexToDec(hexStr);
            return UnixTimeStampToDateTime(timestamp);
        }
        public static string LongToIp(this long ip)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ip >> 0x18 & 0xff).Append(".");
            sb.Append(ip >> 0x10 & 0xff).Append(".");
            sb.Append(ip >> 0x8 & 0xff).Append(".");
            sb.Append(ip & 0xff);
            return sb.ToString();
        }
        public static string LongToIpEndian(this long ip)
        {
            byte[] b = BitConverter.GetBytes(ip);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(b[i]).Append(".");
            }
            return sb.ToString().TrimEnd('.');
        }
        public static DateTime HexToDateTime(this long timestamp)
        {
            return UnixTimeStampToDateTime(timestamp);
        }
        public static Dictionary<short, byte[]> ReadTLVMap(this IByteBuffer buf)
        {
            Dictionary<short, byte[]> tlv_map = new Dictionary<short, byte[]>(new extension.MyDictionaryComparer());
            short tlv_count = buf.ReadShort();
            for (int i = 0; i < tlv_count; i++)
            {
                short tag = buf.ReadShort();
                short len = buf.ReadShort();
                byte[] value = new byte[len];
                buf.ReadBytes(value, 0, len);
                tlv_map.Add(tag, value);
            }
            return tlv_map;
        }
    }
}
