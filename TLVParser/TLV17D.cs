using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x17D)]
    public class TLV17D : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(value.ReadShort().HexPadLeft().HexDump()).AppendLine();
            sb.Append(value.ReadInt().HexPadLeft().HexDump()).AppendLine();
            short url_len = value.ReadShort();
            sb.Append(url_len.HexPadLeft().HexDump()).Append($" //url_len={url_len}").AppendLine();
            byte[] url = value.ReadRemainingBytes();
            sb.Append(url.HexDump()).Append($" //[{Encoding.UTF8.GetString(url)}]").AppendLine();

            return sb.ToString();
        }
    }
}
