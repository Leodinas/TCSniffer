using DotNetty.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSniffer.TLVParser
{
    public interface IParser
    {
        string Parse(IByteBuffer value);
    }
}
