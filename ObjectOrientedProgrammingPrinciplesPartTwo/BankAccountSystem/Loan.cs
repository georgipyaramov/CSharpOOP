using System;
using System.Linq;

namespace BankAccountSystem
{
    public class Loan : BankAccount, IDepositable
    {
        public Loan(int period, double interestRate, Customer customer, decimal currentAmount = 0m) :
            base(period, interestRate, customer, currentAmount)
        {
        }
    
        public void DepositMoney(decimal amount)
        {
            this.CurrentAmount += amount;
        }

        public override decimal CalculateInterest()
        {
            int period = this.Period;
            if (this.Customer == BankAccountSystem.Customer.Company)
            {
                period -= 2;
            }
            else
            {
                period -= 3;
            }            
            return (decimal)(period * this.InterestRate);
        } 
    }
}
