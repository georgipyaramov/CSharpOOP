using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class PathStorage
{
    public static void SavePath(Path path)
    {
        StreamWriter writer = new StreamWriter("path.txt");
        using (writer)
        {
            writer.WriteLine(path.ToString());
        }
    }
    public static Path LoadPath()
    {
        StreamReader reader = new StreamReader("path.txt");
        using (reader)
        {           
            Path path = new Path(3);
            string currentLine = reader.ReadLine();
            while (currentLine != null && currentLine != "")
            {
                string[] coords = currentLine.Split(',', '[', ']');
                Point3D point = new Point3D(float.Parse(coords[1]), float.Parse(coords[2]), float.Parse(coords[3]));
                currentLine = reader.ReadLine();               
                path.AddPoint(point);
            }
            return path;
        }
    }
}

