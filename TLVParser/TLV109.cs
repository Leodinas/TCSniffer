using DotNetty.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;

namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x109)]
    public class TLV109 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HexUtil.ReadRemainingBytes(value).HexDump())
                .Append(" //md5(androidID)")
                .AppendLine();
            return sb.ToString();

        }

    }
}