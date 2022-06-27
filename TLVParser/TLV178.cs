using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{

    [attributes.TLVParser(0x178)]
    public class TLV178 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            short country_code = value.ReadShort();
            short mobile_len = value.ReadShort();
            string mobile = value.ReadCharSequence(mobile_len, Encoding.UTF8).ToString();
            int smscode_status = value.ReadInt();
            short available_msg_cnt = value.ReadShort();
            short time_limit = value.ReadShort();

            sb.Append(country_code.HexPadLeft().HexDump()).Append(" //country_code").AppendLine();
            sb.Append(mobile_len.HexPadLeft().HexDump()).Append($" //mobile_len={mobile_len}").AppendLine();
            sb.Append(Encoding.UTF8.GetBytes(mobile).HexDump()).Append($" //[{mobile}]").AppendLine();
            sb.Append(smscode_status.HexPadLeft().HexDump()).Append(" //smscode_status").AppendLine();
            sb.Append(available_msg_cnt.HexPadLeft().HexDump()).Append(" //available_msg_cnt").AppendLine();
            sb.Append(time_limit.HexPadLeft().HexDump()).Append(" //time_limit").AppendLine();

            return sb.ToString();
        }
    }
}
