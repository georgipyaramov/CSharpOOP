using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Test
    {
        static void Main()
        {
            Shape[] arrOfShapes = {new Circle(5d),
                                   new Triangle(5d, 6d),
                                   new Rectangle(5d, 6d)
                                   };
            double[] area = new double[arrOfShapes.Length];
            //Unsorted
            Console.WriteLine("Unsorted");
            for (int i = 0; i < arrOfShapes.Length; i++)
            {
                area[i] = arrOfShapes[i].CalculateSurface();
                Console.WriteLine(arrOfShapes[i]);
            }
            //Sorting by surface
            Array.Sort(area, arrOfShapes);
            //Sorted
            Console.WriteLine("Sorted");
            foreach (var shape in arrOfShapes)
            {
                Console.WriteLine(shape);
            }

        }
    }
}
