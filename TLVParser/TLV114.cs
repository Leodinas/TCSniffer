using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x114)]
    public class TLV114 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] userStKey = HexUtil.ReadRemainingBytes(value);

            sb.Append(userStKey.HexDump()).Append(" //userSt").AppendLine();

            return sb.ToString();
        }
    }
}
