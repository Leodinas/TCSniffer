using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x16D)]
    public class TLV16D : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            byte[] superkey = HexUtil.ReadRemainingBytes(value);
            sb.Append(superkey.HexDump()).AppendLine()
                .Append($"//[superkey: {Encoding.UTF8.GetString(superkey)}]")
                .AppendLine();
            return sb.ToString();
        }
    }
}
