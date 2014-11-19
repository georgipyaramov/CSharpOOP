using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : INameable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures = 0, int numberOfExercises = 0)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }
    
        public string Name
        {
            get 
            {
                return this.name;                
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }

        public int NumberIfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
