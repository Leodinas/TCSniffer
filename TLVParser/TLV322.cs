using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x322)]
    public class TLV322 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] device_token = HexUtil.ReadRemainingBytes(value);

            sb.Append(device_token.HexDump()).Append(" //device_token").AppendLine();
            return sb.ToString();
        }
    }
}
