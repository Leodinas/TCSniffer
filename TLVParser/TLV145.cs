using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x145)]
    public class TLV145 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HexUtil.ReadRemainingBytes(value).HexDump())
                .Append(" //guid md5(androidID + macAddress)")
                .AppendLine();
            return sb.ToString();
        }
    }
}
