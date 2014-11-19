using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02_HumanWorker;

namespace _02_HumanWorker
{
    public class Worker : Human
    {
        private string firstName;
        private string lastName;
        private decimal weekSalary;
        private int workHoursPerDay;
    
        public Worker(string firstName, string lastName, decimal weekSalary = 0, int workHours = 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHours;
        }

        public override string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public override string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result = this.weekSalary / this.workHoursPerDay;
            return result;
        }
    }
}
