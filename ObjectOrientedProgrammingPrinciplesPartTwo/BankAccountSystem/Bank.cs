using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountSystem
{
    public class Bank
    {
        private readonly string name;
        private List<BankAccount> accounts;

        public Bank(string name)
        {
            this.name = name;
            this.accounts = new List<BankAccount>();
        }

        public List<BankAccount> Accounts
        {
            get
            {
                return this.accounts;
            }
        }

        public void AddAcount(BankAccount account)
        {
            this.accounts.Add(account);
        }
    }
}
