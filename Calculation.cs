using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class Calculation
    {
         public void calculate(int num1, int num2)
         {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute.");
                Console.WriteLine(result);
            }
         }
        public void calculateAnother()
        {
            int num1, num2, result = 0;
            try
            {
                Console.Write("Enter First Number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Sacond Number: ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Div Exception Occurred");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception Occurred");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute.");
                Console.WriteLine(result);
            }
        }
    }
}
