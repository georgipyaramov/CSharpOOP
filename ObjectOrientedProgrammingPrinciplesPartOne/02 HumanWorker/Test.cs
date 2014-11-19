using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_HumanWorker;

namespace HumanWorker
{
    class Test
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Todor", "Goshev", 5));
            listOfStudents.Add(new Student("Gosho", "Petrov", 6));
            listOfStudents.Add(new Student("Pesho", "Goshev", 6));
            listOfStudents.Add(new Student("Stoyan", "Goshev", 3));
            listOfStudents.Add(new Student("Sasho", "Goshev", 3));
            listOfStudents.Add(new Student("Plamen", "Goshev", 2));
            listOfStudents.Add(new Student("Aleksandar", "Goshev", 4));
            listOfStudents.Add(new Student("Gosho", "Petrov", 4));
            listOfStudents.Add(new Student("Atanas", "Goshev", 2));
            listOfStudents.Add(new Student("Gosho", "Atanasov", 5));

            List<Worker> listOfWorkers = new List<Worker>();
            listOfWorkers.Add(new Worker("Todor", "Goshev", 100, 12));
            listOfWorkers.Add(new Worker("Gosho", "Petrov", 50, 8));
            listOfWorkers.Add(new Worker("Pesho", "Goshev", 85, 12));
            listOfWorkers.Add(new Worker("Stoyan", "Goshev", 125, 12));
            listOfWorkers.Add(new Worker("Sasho", "Goshev", 110, 8));
            listOfWorkers.Add(new Worker("Plamen", "Goshev", 120, 12));
            listOfWorkers.Add(new Worker("Aleksandar", "Goshev", 200, 8));
            listOfWorkers.Add(new Worker("Gosho", "Petrov", 185, 12));
            listOfWorkers.Add(new Worker("Atanas", "Goshev", 205, 4));
            listOfWorkers.Add(new Worker("Gosho", "Atanasov", 100, 12));

            var students =
                from student in listOfStudents
                orderby student.Grade
                select student;

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            var workers =
                from worker in listOfWorkers
                orderby worker.MoneyPerHour() descending
                select worker;

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            List<Human> merged = new List<Human>();
            for (int i = 0; i < listOfStudents.Count; i++)
            {
                merged.Add(listOfStudents[i]);
            }
            for (int i = 0; i < listOfWorkers.Count; i++)
            {
                merged.Add(listOfWorkers[i]);
            }
            merged = merged.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();
            Console.WriteLine();
            foreach (var human in merged)
            {
                Console.WriteLine(human);
            }
        }

    }
}
