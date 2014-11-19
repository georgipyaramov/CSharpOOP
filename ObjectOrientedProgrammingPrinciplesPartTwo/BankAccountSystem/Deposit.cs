using System;
using System.Linq;


namespace BankAccountSystem
{
    public class Deposit : BankAccount, IDepositable, IDrawable
    {
        public Deposit(int period, double interestRate, Customer customer, decimal currentAmount = 0m) :
            base(period, interestRate, customer, currentAmount)
        {
        }
    
        public void DepositMoney(decimal amount)
        {
            this.CurrentAmount += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > this.CurrentAmount)
            {
                throw new ArgumentException("The amount must be less then or equel to the current amount");
            }
            this.CurrentAmount -= amount;
        }

        public override decimal CalculateInterest()
        {
            if (this.CurrentAmount < 1000)
            {
                return 0m;
            }
            return (decimal)(this.Period * this.InterestRate);
        }
    }
}
