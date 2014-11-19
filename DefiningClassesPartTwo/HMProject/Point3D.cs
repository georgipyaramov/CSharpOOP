using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Point3D
{
    private float coordX;
    private float coordY;
    private float coordZ;
    private static readonly Point3D pointO = new Point3D(0, 0, 0);

    public Point3D(float X, float Y, float Z)
    {
        this.coordX = X;
        this.coordY = Y;
        this.coordZ = Z;
    }
    public float X
    {
        get { return this.coordX; }
    }
    public float Y
    {
        get { return this.coordY; }
    }
    public float Z
    {
        get { return this.coordZ; }
    }
    public static Point3D PointO
    {
        get { return pointO; }
    }
    public override string ToString()
    {
        return string.Format("[{0},{1},{2}]", coordX, coordY, coordZ);
    }
}

