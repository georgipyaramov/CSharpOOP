using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Call
{
    private DateTime dateAndTime = new DateTime();
    private string dialedNumber;
    private int duration;

    public Call(int recipient, int duration)
    {
        this.dateAndTime = DateTime.Now;
        this.dialedNumber = recipient.ToString();
        this.duration = duration;
    }
    public int Duration
    {
        get { return this.duration; }
    }
    public override string ToString()
    {        
        return string.Format("Date and time of the call: {0:dd.MM.yyyy H:mm:ss}\n"
        + "Dialed number: 0{1}\nDuration of the call: {2} seconds", this.dateAndTime, dialedNumber, duration);
    }
}


