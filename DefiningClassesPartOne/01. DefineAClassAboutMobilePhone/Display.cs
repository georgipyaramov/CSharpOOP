using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Display
{
    private float size;
    private int colors;

    public Display()
    { 
    }
    public Display(float size, int colors)
    {
        if (size < 0 || colors < 0)
        {
            throw new ArgumentException();
        }
        else
        {
            this.size = size;
            this.colors = colors;
        }
        
    }
    public override string ToString()
    {
        return string.Format("Size: {0}\nColors: {1}", this.size, this.colors);
    }
}

