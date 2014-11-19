using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Test it in "DefineAClassAboutMobilePhone". The Main() method is there.
public class GSMTest
{
    public static void Test()
    {
        GSM[] testArr = new GSM[3];
        testArr[0] = new GSM("Lumia", "Nokia", 850.00m);
        testArr[1] = new GSM("K750", "Sony Ericsson", 150m, "G Y");
        testArr[2] = new GSM("Galaxy S", "Samsung");
        for (int i = 0; i < testArr.Length; i++)
        {
            Console.WriteLine(testArr[i].ToString());
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(GSM.Iphone4S.ToString());        
    }
}

