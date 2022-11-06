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

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

namespace ITMO.CSCourse2022.Task4._2
{
    internal class ProgramTestSwap
    {
        static void Main()
        {
            int x, y;

            Console.WriteLine("Enter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(" Before swap: " + x + ", " + y);

            Utils.Swap(ref x, ref y);
            Console.WriteLine(" After swap: " + x + ", " + y);
        }
    }
}
