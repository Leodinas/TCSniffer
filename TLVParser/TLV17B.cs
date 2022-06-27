using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x17B)]
    public class TLV17B : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            short available_msg_cnt = value.ReadShort();
            short time_limit = value.ReadShort();

            sb.Append(available_msg_cnt.HexPadLeft().HexDump()).Append($" //available_msg_cnt={available_msg_cnt}").AppendLine();
            sb.Append(time_limit.HexPadLeft().HexDump()).Append($" //time_limit={time_limit}").AppendLine();

            return sb.ToString();
        }
    }
}
