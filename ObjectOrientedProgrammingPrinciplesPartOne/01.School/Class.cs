using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Class
    {
        private string identifier;
        private List<Student> students;
        private List<Teacher> teachers;        

        public Class(string identifier)
        {
            this.identifier = identifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }            
        }

        public void AddStudent(params Student[] students)
        {
            foreach (var student in students)
            {
                this.students.Add(student);
            }
        }

        public void AddTeacher(params Teacher[] teachers)
        {
            foreach (var teacher in teachers)
            {
                this.teachers.Add(teacher);
            }
        }

        public void PrintStudents()
        {
            for (int i = 0; i < this.students.Count; i++)
            {
                Console.WriteLine(this.students[i].ToString());
            }
        }

        public void PrintTeachers()
        {
            for (int i = 0; i < this.teachers.Count; i++)
            {
                Console.WriteLine(this.teachers[i].ToString());
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.students.Count; i++)
            {
                sb.Append(string.Format("\n\nStudents:\n{0}", students[i].ToString()));
            }
            sb.Append("\n\nTeachers:");
            for (int i = 0; i < this.teachers.Count; i++)
            {
                sb.Append(string.Format("\n{0}", teachers[i].ToString()));
            }
            return string.Format("\n\nIdentifier:\n{0}", this.identifier) + sb.ToString();
        }
    }
}
