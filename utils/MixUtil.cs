using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSniffer.utils
{
    public static class MixUtil
    {
        public static Type[] GetExportedTypes(this Type assembly)
        {
            return System.Reflection.Assembly.GetAssembly(assembly).GetExportedTypes();
        }
    }
}
