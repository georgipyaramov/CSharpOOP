using System;
using System.Linq;

namespace Animals
{
    public class Dog : Animal
    {

        public Dog(string name, int age, Sex sex) 
            : base(name, age, sex)
        {            
        }
    
        public override void MakeSound()
        {
            Console.WriteLine("Бау бау");
        }
    }
}
