using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry
{
    public class Circle : Shape
    {
        public Circle(double diameter) : 
            base(diameter, diameter)
        {
        }
        public override double CalculateSurface()
        {
            return (Math.PI * (this.Height / 2)) * (Math.PI * (this.Height / 2));
        }
    }
}
