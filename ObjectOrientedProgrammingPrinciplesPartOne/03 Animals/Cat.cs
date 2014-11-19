using System;
using System.Linq;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat()
        {
        }
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }
    
        public override void MakeSound()
        {
            Console.WriteLine("Мърррррррр Мяууууууу");
        }
    }
}
