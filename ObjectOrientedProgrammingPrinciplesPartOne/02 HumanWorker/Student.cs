using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02_HumanWorker;

namespace _02_HumanWorker
{
    public class Student : Human
    {
        private string firstName;
        private string lastName;
        private int grade;

        public Student(string firstName, string lastName, int grade = 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
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
        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
    }
}
