using DotNetty.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;

namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x104)]
    public class TLV104 : IParser
    {


        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] tlv104_buf = HexUtil.ReadRemainingBytes(value);

            sb.Append(tlv104_buf.HexDump()).Append($" //[Text: {Encoding.UTF8.GetString(tlv104_buf)}]").AppendLine();

            return sb.ToString();
        }
    }
}
