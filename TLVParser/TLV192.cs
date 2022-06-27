using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x192)]
    public class TLV192 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] tlv192_buf = HexUtil.ReadRemainingBytes(value);

            sb.Append(tlv192_buf.HexDump()).Append($" //[Text: {Encoding.UTF8.GetString(tlv192_buf)}]").AppendLine();

            return sb.ToString();
        }
    }
}
