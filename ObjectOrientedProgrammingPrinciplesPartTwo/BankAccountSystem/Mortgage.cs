using System;
using System.Linq;


namespace BankAccountSystem
{
    public class Mortgage : BankAccount, IDepositable
    {
        public Mortgage(int period, double interestRate, Customer customer, decimal currentAmount = 0m) :
            base(period, interestRate, customer, currentAmount)
        {
        }
    
        public void DepositMoney(decimal amount)
        {
            this.CurrentAmount += amount;
        }

        public override decimal CalculateInterest()
        {
            decimal interest = 0;
            int part = 12;
            int rest = this.Period - part;
            if (this.Customer == BankAccountSystem.Customer.Company)
            {
                interest += (decimal)((part * this.InterestRate) / 2);
                interest += (decimal)(rest * this.InterestRate);
            }
            else
            {
                part = 6;
                interest += (decimal)(rest * this.InterestRate);
            }
            return interest;
        }   
    }
}
