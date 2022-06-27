using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSniffer.utils;
using DotNetty.Buffers;
namespace TCSniffer.TLVParser
{
    [attributes.TLVParser(0x177)]
    public class TLV177 : IParser
    {
        public string Parse(IByteBuffer value)
        {
            StringBuilder sb = new StringBuilder();

            byte unknownConst1 = value.ReadByte();
            int releaseTimestamp = value.ReadInt();
            short sdkVersionLen = value.ReadShort();
            string sdkVersion = value.ReadCharSequence(sdkVersionLen, Encoding.UTF8).ToString();

            sb.Append(unknownConst1.HexPadLeft().HexDump()).AppendLine();
            sb.Append(releaseTimestamp.HexPadLeft().HexDump()).Append($" //[releaseTimestamp: {HexUtil.UnixTimeStampToDateTime(releaseTimestamp)}]").AppendLine();
            sb.Append(sdkVersionLen.HexPadLeft().HexDump()).AppendLine();
            sb.Append(Encoding.UTF8.GetBytes(sdkVersion).HexDump()).Append($" //[sdkVersion: {sdkVersion}]").AppendLine();

            return sb.ToString();
        }
    }
}
