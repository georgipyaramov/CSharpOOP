using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        private List<Class> classes;

        public School()
        {
            this.classes = new List<Class>();
        }

        public List<Class> Clasess
        {
            get
            {
                return this.classes;
            }
        }

        public void AddClass(Class classs)
        {
            this.classes.Add(classs);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.classes.Count; i++)
            {
                sb.Append(this.classes[i].ToString());
            }
            return string.Format("Classes:\n\n") + sb;
        }
    }
}
