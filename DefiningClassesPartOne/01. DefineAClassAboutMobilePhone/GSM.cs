using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GSM
{
    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;
    private Battery battery;
    private Display display;
    private static GSM iPhone4S;
    private List<Call> calls = new List<Call>();

    public GSM(string model, string manufacturer)
    {
        if (!string.IsNullOrEmpty(model) && !string.IsNullOrEmpty(manufacturer))
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.battery = new Battery();
            this.display = new Display();
        }
        else
        {
            throw new ArgumentNullException();
        }
        
    }
    public GSM(string model, string manufacturer, decimal price, string owner)
    {
        if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(manufacturer) || 
            price < 0 || string.IsNullOrEmpty(owner))
        {
            throw new ArgumentException();
        }
        else
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery();
            this.display = new Display();
        }
               
    }
    public GSM(string model, string manufacturer, decimal price)
    {
        if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(manufacturer) ||
            price < 0)
        {
            throw new ArgumentException();
        }
        else
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = null;
            this.battery = new Battery();
            this.display = new Display();
        }

    }
    public GSM(string model, string manufacturer, decimal price, string owner, 
        string batteryModel, float batteryIdleHours, float batteryTalkHours,
        float displaySize, int displyColors)
    {
        if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(manufacturer) ||
            price < 0 || string.IsNullOrEmpty(owner))
        {
            throw new ArgumentException();
        }
        else
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }        
        this.battery = new Battery(batteryModel, batteryIdleHours, batteryTalkHours);
        this.display = new Display(displaySize, displyColors);
    }
    static GSM()
    {
        iPhone4S = new GSM("IPhone4S", "Apple"); 
    }
    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new AccessViolationException();
            }
            else
            {
                this.model = value;
            }
        }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new AccessViolationException();
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }
    public decimal Price
    {
        get { return (decimal)this.price; }
        set
        {
            if (value < 0)
            {
                throw new AccessViolationException();
            }
            else
            {
                this.price = value;
            }
        }
    }
    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new AccessViolationException();
            }
            else
            {
                this.owner = value;
            }
        }
    }
    public Battery Battery
    {
        get {return this.battery;}
    }
    public Display Display
    {
        get { return this.display; }
    }
    public static GSM Iphone4S
    {
        get { return iPhone4S; }
    }
    public List<Call> CallHistory
    {
        get { return this.calls; }
    }
    public void MakeACall(int recipient, int duration)
    {
        Call call = new Call(recipient, duration);
        this.CallHistory.Add(call);
    }
    public void DeleteACall(int position)
    {
        this.CallHistory.RemoveAt(position);
    }
    public void ClearCallHistory()
    {
        this.CallHistory.Clear();
    }
    public decimal TotalCostOfAllCalls()
    {
        decimal cost = 0.37m;
        decimal totalCost = 0;
        float totalTime = 0;
        for (int i = 0; i < CallHistory.Count; i++)
        {
            totalTime += (float)this.CallHistory[i].Duration;
        }
        totalCost = (decimal)(totalTime / 60) * cost;
        return totalCost;
    }
    public void PrintTheCallHistory()
    {
        if (this.CallHistory.Count > 0)
        {
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                Console.WriteLine(this.CallHistory[i].ToString());
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The call history is empty.");
        }
    }
    public override string ToString()
    {
        if (battery != null && display != null)
        {
            return string.Format("GSM\nModel: {0}\nManufacturer: {1}\nPrice: {2}BGN\nOwner: {3}",
            this.model, this.manufacturer, this.price, this.owner) + string.Format("\nBattery\n{0}",
            this.battery.ToString()) + string.Format("\nDisplay\n{0}", this.display.ToString());
        }
        else if (battery != null && display == null)
        {
            return string.Format("GSM\nModel: {0}\nManufacturer: {1}\nPrice: {2}BGN\nOwner: {3}",
            this.model, this.manufacturer, this.price, this.owner) + string.Format("\nBattery\n{0}",
            this.battery.ToString());
        }
        else if (battery == null && display != null)
        {
            return string.Format("GSM\nModel: {0}\nManufacturer: {1}\nPrice: {2}BGN\nOwner: {3}",
            this.model, this.manufacturer, this.price, this.owner) + string.Format("\nDisplay\n{0}", this.display.ToString());
        }
        else
        {
            return string.Format("GSM\nModel: {0}\nManufacturer: {1}\nPrice: {2}BGN\nOwner: {3}",
            this.model, this.manufacturer, this.price, this.owner);
        }
        
    }
}

