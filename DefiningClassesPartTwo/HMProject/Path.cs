using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Path
{
    private Point3D[] sequenceOfPoints;
    private int index = 0;
    public Path(int numberOfPoints)
    {
        sequenceOfPoints = new Point3D[numberOfPoints];
    }
    public void AddPoint(Point3D point)
    {
        if (index == sequenceOfPoints.Length)
        {
            throw new IndexOutOfRangeException();
        }
        this.sequenceOfPoints[index] = point;
        index++;
    }
    public override string ToString()
    {
        string toBePrinted = null;
        for (int i = 0; i < sequenceOfPoints.Length; i++)
        {
            toBePrinted += string.Format("[{0},{1},{2}]" + System.Environment.NewLine, this.sequenceOfPoints[i].X, this.sequenceOfPoints[i].Y, this.sequenceOfPoints[i].Z);
        }
        return toBePrinted;
    }
}

