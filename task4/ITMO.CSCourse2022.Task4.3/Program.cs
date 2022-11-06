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

    public static bool Factorial(int n, out int answer)
    {
        int k, f;
        bool ok = true;

        if (n < 0)
            ok = false;

        try
        {
            checked
            {
                f = 1;
                for(k=2; k<=n; k++)
                {
                    f = f * k;
                }
            }
        }
        catch(Exception)
        {
            f = 0;
            ok = false;
        }
        answer = f;
        return ok;

    }
}

namespace ITMO.CSCourse2022.Task4._3
{
    internal class ProgramTestFactorial
    {
        static void Main()
        {
            bool ok;
            int f, x;

            Console.WriteLine("Enter a whole number: ");
            x = int.Parse(Console.ReadLine());
            
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine(" Factorial (" + x + ") = " + f);
            else
                Console.WriteLine(" Cannot compute this factorial ");        
        
        }
    }
}
