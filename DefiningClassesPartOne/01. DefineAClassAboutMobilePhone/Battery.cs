using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BatteryType 
    {
        Li_Ion, NiMH, NiCd
    }
public class Battery
{
    private string model;
    private float hoursIdle;
    private float hoursTalk;
    private BatteryType batteryType;
    
    public Battery()
    {
        //this.model = null;
        //this.hoursIdle = 0;
        //this.hoursTalk = 0;

    }
    public Battery(string model, float idle, float talk)
    {
        if (string.IsNullOrEmpty(model) || idle < 0 || talk < 0)
        {
            throw new ArgumentException();
        }
        else
        {
            this.model = model;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
        }
        
    }
    public Battery(string model, float idle, float talk, BatteryType type)
    {
        if (string.IsNullOrEmpty(model) || idle < 0 || talk < 0)
        {
            throw new ArgumentException();
        }
        else
        {
            this.model = model;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
        }        
        this.batteryType = type;
    }
    public string Model
    {
        get { return this.model; }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException();
            }
            else
            {
                this.model = value;
            }
        }
    }
    public float HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.hoursIdle = value;
            }
        }
    }
    public float HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.hoursTalk = value;
            }
        }
    }
    public BatteryType BatteryType
    {
        get { return this.batteryType; }
    }
    public override string ToString()
    {
        return string.Format("Model: {0}\nHours Idle: {1}\nHours Talk: {2}", this.model, this.hoursIdle, this.hoursTalk);
    }
}



