using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolTest
    {
        static void Main()
        {
            School school = new School();

            Class someClass = new Class("10A");
            Class secondClass = new Class("10B");

            Discipline math = new Discipline("Math", 8, 4);
            Discipline history = new Discipline("History", 12, 2);
            Discipline music = new Discipline("Music", 4, 7);

            Student pesho = new Student("Pesho", 1);
            Student sasho = new Student("Sasho", 2);

            Teacher ivanov = new Teacher("Ivanov");
            Teacher petrov = new Teacher("Petrov");

            school.AddClass(someClass);
            school.AddClass(secondClass);
            ivanov.AddDiscipline(math, history);
            petrov.AddDiscipline(music);
            someClass.AddStudent(pesho);
            someClass.AddTeacher(ivanov, petrov);
            secondClass.AddStudent(sasho);
            secondClass.AddTeacher(ivanov, petrov);
            //Console.WriteLine(someClass.ToString());
            Console.WriteLine(school.ToString());
        }
    }
}
