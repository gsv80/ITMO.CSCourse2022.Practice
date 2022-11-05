using System;

namespace Lab1.Task1{
    internal class Greeting
    {
        static void Main()
        {
            string myName;
            Console.WriteLine("Enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Welcome {0}", myName);
            Console.ReadLine();
            
        }
    }
}
