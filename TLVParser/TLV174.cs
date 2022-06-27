using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x174)]
    public class TLV174 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] tlv174_buf = HexUtil.ReadRemainingBytes(value);

            sb.Append(tlv174_buf.HexDump()).Append($" //[Text: {Encoding.UTF8.GetString(tlv174_buf)}]").AppendLine();

            return sb.ToString();
        }
    }
}
