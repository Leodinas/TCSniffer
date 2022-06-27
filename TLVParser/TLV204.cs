using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x204)]
    // devLockInfo
    public class TLV204 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] otherDevLockVerifyUrl = value.ReadRemainingBytes();

            sb.Append(otherDevLockVerifyUrl.HexDump()).Append($" //[otherDevLockVerifyUrl: {Encoding.UTF8.GetString(otherDevLockVerifyUrl)}]").AppendLine();

            return sb.ToString();
        }
    }
}
