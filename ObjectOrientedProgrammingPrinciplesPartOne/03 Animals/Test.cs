using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class Test
    {
        static void Main()
        {
            List<Animal> differentAnimalsList = new List<Animal>();
            differentAnimalsList.Add(new Kitten("pesho", 10));
            differentAnimalsList.Add(new Tomcat("misho", 20));
            differentAnimalsList.Add(new Frog("gabcho", 50, Sex.Male));
            differentAnimalsList.Add(new Frog("gabcho2", 30, Sex.Male));
            differentAnimalsList.Add(new Dog("sharo", 25, Sex.Male));
            differentAnimalsList.Add(new Kitten("puhcho", 5));

            Animal.AverageAge(differentAnimalsList.ToArray());

        }
    }
}
