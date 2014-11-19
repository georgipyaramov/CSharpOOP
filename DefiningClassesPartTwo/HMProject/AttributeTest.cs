using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[Version("1.0")]
public class AttributeTest
{    
    static void Main()
    {
        Type type = typeof(AttributeTest);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute versionAttribute in allAttributes)
        {
            Console.WriteLine("This class version is {0} ",
                versionAttribute.Name);
        }
        TestProgram.Test();    //Tests everything else.
    }
}

