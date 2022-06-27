using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x305)]
    public class TLV305 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HexUtil.ReadRemainingBytes(value).HexDump())
                .Append(" //d2key or session key 登录成功后续的操作需要用这个key作为tea加密的秘钥")
                .AppendLine();
            return sb.ToString();
        }
    }
}
