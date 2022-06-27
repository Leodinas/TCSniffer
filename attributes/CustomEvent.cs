using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSniffer.attributes
{
    public class CustomEvent : Attribute
    {
        private readonly string windowName;

        public string WindowName => windowName;

        public CustomEvent(string windowName)
        {
            this.windowName = windowName;
        }
    }
}
