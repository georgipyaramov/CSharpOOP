using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountSystem
{
    public abstract class BankAccount : ICalculateInterest
    {
        private int period;
        private double interestRate;
        private decimal currentAmount;
        private Customer customer;

        public BankAccount(int period, double interestRate, Customer customer, decimal currentAmount = 0m)
        {
            this.period = period;
            this.interestRate = interestRate;
            this.currentAmount = currentAmount;
            this.customer = customer;
        }

        public int Period
        {
            get
            {
                return this.period;
            }
            protected set
            {
                this.period = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public decimal CurrentAmount
        {
            get
            {
                return this.currentAmount;
            }
            protected set
            {
                this.currentAmount = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
        }
    
        public abstract decimal CalculateInterest();

        
    }
}
