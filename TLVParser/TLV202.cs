using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x202)]
    public class TLV202 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            short md5_bssid_len = value.ReadShort();
            byte[] md5_bssid = value.ReadBytes(md5_bssid_len).Array;
            short bssid_len = value.ReadShort();
            string bssid = value.ReadCharSequence(bssid_len, Encoding.UTF8).ToString();

            sb.Append(md5_bssid_len.HexPadLeft().HexDump()).AppendLine();
            sb.Append(md5_bssid.HexDump()).Append(" //md5(bssid)").AppendLine();
            sb.Append(bssid_len.HexPadLeft().HexDump()).AppendLine();
            sb.Append(Encoding.UTF8.GetBytes(bssid).HexDump()).Append($" //[bssid: {bssid}]").AppendLine();

            return sb.ToString();
        }
    }
}
