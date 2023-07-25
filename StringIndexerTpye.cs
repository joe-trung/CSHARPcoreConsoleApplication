using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class StringIndexerTpye
    {
        private string[] strArray = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index>= strArray.Length)
                    throw new ArgumentOutOfRangeException("index is out of range");
                return strArray[index];
            }
            set
            {
                if (index >= strArray.Length || index < 0)
                    throw new ArgumentOutOfRangeException("index is out of range");
                strArray[index] = value;
            }
        }
    }
}
