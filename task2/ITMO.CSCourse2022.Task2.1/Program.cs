using System;

namespace ITMO.CSCourse2022.Task2._1
{

    public enum AccountType 
    {  
        Checking, 
        Deposit 
    }
  
    internal class ProgramEnum
    {
        static void Main()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account is: {0}", goldAccount);
            Console.WriteLine("The Customer Account is: {0}", platinumAccount);
        }
    }
}
