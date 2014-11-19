using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class Test
    {
        static void Main()
        {
            Bank someBank = new Bank("Bank");
            BankAccount loan = new Loan(12, 21, Customer.Individual, 1005);
            BankAccount mortgage = new Mortgage(120, 7.5, Customer.Company, 85000);
            BankAccount deposit = new Deposit(24, 4.6, Customer.Individual, 700);
            someBank.AddAcount(loan);
            someBank.AddAcount(mortgage);
            someBank.AddAcount(deposit);
            for (int i = 0; i < someBank.Accounts.Count; i++)
            {
                Console.WriteLine(someBank.Accounts[i].CalculateInterest());
            }

        }
    }
}
