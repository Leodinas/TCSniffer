using DotNetty.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;

namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x103)]
    public class TLV103 : IParser
    {


        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] userStSig = HexUtil.ReadRemainingBytes(value);

            sb.Append(userStSig.HexDump()).Append(" //userStSig").AppendLine();
            return sb.ToString();
        }
    }
}
