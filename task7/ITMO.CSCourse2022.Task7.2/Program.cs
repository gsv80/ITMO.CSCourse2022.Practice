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
        catch(OverflowException e)
        {
            f = 0;
            ok = false;
            Console.WriteLine(e.Message);
        }
        answer = f;
        return ok;

    }
    public static void Reverse(ref string s)
    {
        string sRev = "";
        for (int k  = s.Length-1; k>=0; k--)
        {
            sRev = sRev + s[k];
        }
        s = sRev;
    }
    }


namespace ITMO.CSCourse2022.Task7._2
{
    internal class ProgramTestReverseString
    {
        static void Main()
        {
            string message;

            Console.WriteLine("Enter the string to reverse");
            message = Console.ReadLine();

            Utils.Reverse(ref message);

            Console.WriteLine(message);
        }
    }
}
