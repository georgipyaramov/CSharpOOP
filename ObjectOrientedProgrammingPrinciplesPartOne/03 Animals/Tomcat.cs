using System;
using System.Linq;

namespace Animals
{
    public class Tomcat : Cat
    {
        //public Tomcat(string name, int age, Sex sex)
        //    : base(name, age, sex)
        //{
        //}
        public Tomcat(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.sex = Animals.Sex.Male;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Мърррррррр");
        }
    }
}
