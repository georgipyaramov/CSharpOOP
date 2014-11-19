using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student : INameable
    {
        private string name;
        private int classNumber;

        public Student(string name, int classNumber)
        {
            this.name = name;
            this.classNumber = classNumber;
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
