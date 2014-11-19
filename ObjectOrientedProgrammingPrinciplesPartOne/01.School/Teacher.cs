using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Teacher : INameable
    {
        private string name;
        private List<Discipline> disciplines;

        public Teacher(string name)
        {
            this.name = name;
            this.disciplines = new List<Discipline>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }            
        }

        public void AddDiscipline(params Discipline[] disciplines)
        {
            foreach (var discipline in disciplines)
            {
                this.disciplines.Add(discipline);
            }
            
        }

        public void PrintDisciplines()
        {
            for (int i = 0; i < this.disciplines.Count; i++)
            {
                Console.WriteLine(this.disciplines[i].ToString());
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.disciplines.Count; i++)
			{
                sb.Append(string.Format("\n{0}", disciplines[i].ToString()));			 
			}
            return string.Format("Name:\n{0}\nDisciplines:", this.name) + sb.ToString();

        }
    }
}
