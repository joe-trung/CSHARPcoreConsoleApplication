using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    //publisher model
    internal class EventExample
    {
        //declare delegate
        public delegate void delegate_OddNumber();

        //declare event
        public event delegate_OddNumber event_OddNumber;
        public void addition()
        {
            int num1 = 100; int num2 = 200;
            int result = num1 + num2;
            Console.WriteLine(result);
            if (result%2!=0 && event_OddNumber != null)
            {
                //raised event
                event_OddNumber();
            }

        }
    }
}
