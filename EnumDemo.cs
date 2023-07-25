using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    enum Weekdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class EnumDemo
    {
        public void display()
        {
            Console.WriteLine(Weekdays.Monday);
            int day0 = (int)Weekdays.Monday;
            Console.WriteLine(Weekdays.Monday+":"+ day0);
            Console.WriteLine(Weekdays.Tuesday);
            int day1 = (int)Weekdays.Tuesday;
            Console.WriteLine(Weekdays.Tuesday + ":" + day1);
            Console.WriteLine(Weekdays.Wednesday);
            int day2 = (int)Weekdays.Wednesday;
            Console.WriteLine(Weekdays.Wednesday + ":" + day2);
        }
    }
}
