using System;
using System.Linq;

namespace Animals
{
    public class Kitten : Cat
    {        
        public Kitten(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.sex = Animals.Sex.Female;
        }      
    
        public override void MakeSound()
        {
            Console.WriteLine("Мяууууууу");
        }
    }
}
