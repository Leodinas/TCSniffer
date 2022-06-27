using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSniffer.attributes
{

    public class TLVParser : Attribute
    {
        private readonly short cmd;

        public short Cmd => cmd;

        public TLVParser(short cmd)
        {
            this.cmd = cmd;
        }
    }
}
