using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Task6._1
{
    public enum AccountType
    {
        Checking,
        Deposit
    }
    class CreateAccount
    {
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();
            created.Populate(number, balance);
        }
    }
    class BankAccount
    {   
        public void Populate( long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }

        private long accNo;
        private decimal accBal;
        private AccountType accType;
    }
    internal class ProgramStruct
    {
        static void Main()
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;

            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Account Number: {0}", goldAccount.accNo);
            Console.WriteLine("Account Type: {0}", goldAccount.accType);
            Console.WriteLine("Account Balance: {0}", goldAccount.accBal);

        }
    }
}
