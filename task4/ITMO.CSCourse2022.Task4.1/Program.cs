using System;

class Utils
{
    public static int Greater(int a, int b) 
    {
        if (a > b)
            return a;
        else
            return b;
    }
}

namespace ITMO.CSCourse2022.Task4._1
{
    internal class ProgramTestGreater
    {
        static void Main()
        {
            int x, y, greater;

            Console.WriteLine("Enter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            y = int.Parse(Console.ReadLine());

            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is {0}", greater);
        }
    }
}
