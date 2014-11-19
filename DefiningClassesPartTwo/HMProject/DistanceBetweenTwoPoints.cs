using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DistanceBetweenTwoPoints
{
    public static double Get(Point3D first, Point3D second)
    {
        double distance;
        var xd = second.X - first.X;
        var yd = second.Y - first.Y;
        var zd = second.Z - first.Z;
        distance = Math.Sqrt((xd * xd) + (yd * yd) + (zd * zd));
        return distance;
    }
}

