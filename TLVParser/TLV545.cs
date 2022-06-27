using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x545)]
    public class TLV545 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HexUtil.ReadRemainingBytes(value).HexDump())
                .Append(" //md5(imei or qimei)")
                .AppendLine();
            return sb.ToString();
        }
    }
}
