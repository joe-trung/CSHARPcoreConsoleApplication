using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    static class IntExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
