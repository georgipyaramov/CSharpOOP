using System;
using System.Linq;

namespace Animals
{
    public class Animal : ISound
    {
        internal int age;
        internal  string name;
        internal Sex sex;

        public Animal()
        {

        }
        public Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }       

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public virtual Sex Sex
        {
            get
            {
                return this.sex;
            }
        }
    
        public virtual void MakeSound()
        {
        }
        public static void AverageAge(Animal[] differentAnimalsList)
        {
            Console.WriteLine("Average kitten age: ");
            var result =
                (from animal in differentAnimalsList
                 where animal.GetType() == typeof(Kitten)
                 select animal.Age).Average();
            Console.WriteLine(result);
            Console.WriteLine("Average tomcat age: ");
            result =
                (from animal in differentAnimalsList
                 where animal.GetType() == typeof(Tomcat)
                 select animal.Age).Average();
            Console.WriteLine(result);
            Console.WriteLine("Average frog age: ");
            result =
                (from animal in differentAnimalsList
                 where animal.GetType() == typeof(Frog)
                 select animal.Age).Average();
            Console.WriteLine(result);
            Console.WriteLine("Average dog age: ");
            result =
                (from animal in differentAnimalsList
                 where animal.GetType() == typeof(Dog)
                 select animal.Age).Average();
            Console.WriteLine(result);
        }
    }
}
