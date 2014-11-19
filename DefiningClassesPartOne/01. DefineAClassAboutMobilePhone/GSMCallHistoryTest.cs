using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Test it in "DefineAClassAboutMobilePhone". The Main() method is there.
public class GSMCallHistoryTest
{
    public static void Test()
    {
        GSM myPhone = new GSM("IPhone4", "Apple");
        myPhone.MakeACall(0882333444, 126);
        myPhone.MakeACall(0882333552, 17);
        myPhone.MakeACall(0882365844, 60);
        myPhone.PrintTheCallHistory();
        decimal totalCost = myPhone.TotalCostOfAllCalls();
        Console.WriteLine("Total cost: {0:0.00 BGN}",totalCost);
        int indexOfLongestCall = 0;
        for (int i = 0; i < myPhone.CallHistory.Count - 1; i++)
        {
            if (myPhone.CallHistory[i + 1].Duration > myPhone.CallHistory[i].Duration )
            {
                indexOfLongestCall = i + 1;
            }
            else
            {
                indexOfLongestCall = i;
            }
        }
        myPhone.DeleteACall(indexOfLongestCall);
        totalCost = myPhone.TotalCostOfAllCalls();
        Console.WriteLine("Total cost: {0:0.00 BGN}", totalCost);
        Console.WriteLine();
        myPhone.ClearCallHistory();
        myPhone.PrintTheCallHistory();
    }
    
}

