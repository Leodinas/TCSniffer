using DotNetty.Buffers;
using System.Text;
using TCSniffer.utils;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x10A)]
    public class TLV10A : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte[] tgt = HexUtil.ReadRemainingBytes(value);

            sb.Append(tgt.HexDump()).Append(" //TGT").AppendLine();
            return sb.ToString();
        }
    }
}
