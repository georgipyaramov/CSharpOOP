namespace PersonProject
{
    using System;
    using System.Linq;
    using System.Text;
    public class Person
    {
        private string name;
        private int? age;
        
        public Person(string initialName, int? initialAge = null)
        {
            this.Name = initialName;
            this.Age = initialAge;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("Name: {0}", this.Name));
            string age = string.Format("Age: {0}", this.Age != null ? this.Age.ToString() : "Not specified");
            result.Append(age);
            return result.ToString();
        }

    }
}
