﻿using System;

namespace ITMO.CSCourse2022.Task2._3
{

    public enum AccountType
    {
        Checking,
        Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
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