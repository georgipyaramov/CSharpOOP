using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_HumanWorker
{
    public abstract class Human
    {
        public abstract string FirstName { get; }
        public abstract string LastName { get; }
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
