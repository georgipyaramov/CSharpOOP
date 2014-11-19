namespace PersonProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Test
    {
        static void Main()
        {
            var person = new Person("Pesho");
            Console.WriteLine(person.ToString());
            Console.WriteLine();
            var otherPerson = new Person("Sasho", 20);
            Console.WriteLine(otherPerson.ToString());
        }
    }
}
