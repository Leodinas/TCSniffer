using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x17E)]
    // devLockInfo
    public class TLV17E : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] verifyReason = value.ReadRemainingBytes();

            sb.Append(verifyReason.HexDump()).Append($" //[verifyReason: {Encoding.UTF8.GetString(verifyReason)}]").AppendLine();

            return sb.ToString();
        }
    }
}
