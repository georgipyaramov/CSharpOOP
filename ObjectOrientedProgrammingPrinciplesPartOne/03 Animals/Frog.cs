using System;
using System.Linq;

namespace Animals
{
    public class Frog : Animal
    {

        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }
    
        public override void MakeSound()
        {
            Console.WriteLine("Кряк кряк");
        }
    }
}
