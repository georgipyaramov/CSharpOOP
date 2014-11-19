using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
