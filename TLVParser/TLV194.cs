using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x194)]
    public class TLV194 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HexUtil.ReadRemainingBytes(value).HexDump())
                    .Append(" //md5(imsi)")
                    .AppendLine();
            return sb.ToString();
        }
    }
}
