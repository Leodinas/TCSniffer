using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x120)]
    public class TLV120 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            byte[] skey = HexUtil.ReadRemainingBytes(value);
            sb.Append(skey.HexDump()).Append($" //[skey: {Encoding.UTF8.GetString(skey)}]").AppendLine();
            return sb.ToString();
        }
    }
}
