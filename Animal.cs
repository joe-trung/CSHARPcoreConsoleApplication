using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The Dog barks");
        }
    }

}
