using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class ConsolePrinter
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print(string str, string str1)
        {
            Console.WriteLine(str + " " + str1);
        }

        public void Print(string str, string str1, string str2)
        {
            Console.WriteLine($"{str}, {str1}, {str2}");
        }
    }
}
