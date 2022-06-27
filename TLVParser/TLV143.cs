using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x143)]
    public class TLV143 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] D2 = HexUtil.ReadRemainingBytes(value);

            sb.Append(D2.HexDump()).Append(" //D2").AppendLine();
            return sb.ToString();
        }
    }
}
