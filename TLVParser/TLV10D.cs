using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x10D)]
    public class TLV10D : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] tgtkey = HexUtil.ReadRemainingBytes(value);

            sb.Append(tgtkey.HexDump()).Append(" //TGTKey").AppendLine();
            return sb.ToString();
        }
    }
}
