using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestProgram
{
    public static void Test()
    {
        Point3D p1 = new Point3D(1, 2, 3);
        Point3D p2 = new Point3D(2, 1, 6);
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(DistanceBetweenTwoPoints.Get(p1, p2));
        GenericList<int> shit = new GenericList<int>(4);
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            shit.Add(i);
        }
        shit.RemoveAt(7);
        shit.InsertAt(10, 2);
        shit.Clear();
        Console.WriteLine(shit.ToString());
        Path path = new Path(3);
        path.AddPoint(p1);
        path.AddPoint(p1);
        path.AddPoint(p2);
        PathStorage.SavePath(path);
        Path pathTwo = PathStorage.LoadPath();
        Console.WriteLine(pathTwo.ToString());
    }
}

