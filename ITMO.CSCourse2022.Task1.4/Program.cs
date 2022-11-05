using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Lab1.Task4
{
    internal class ExceptionHandler
    {
        static void Main()
        {
            try
            {
                int i, j;
                string tmp;
                Console.WriteLine("Enter first number");
                tmp = Console.ReadLine();
                i = Int32.Parse(tmp);

                Console.WriteLine("Enter second number");
                tmp = Console.ReadLine();
                j = Int32.Parse(tmp);

                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }


            Console.ReadLine();
        }
    }
}