using System;

public delegate void TimeElapsedEventHandler(object sender, TimeElapsedEventArgs e);

public class TimeElapsedEventArgs : EventArgs
{
    private int ticksLeft;

    public int TicksLeft
    {
        get
        {
            return this.ticksLeft;
        }
    }

    public TimeElapsedEventArgs(int ticksLeft)
    {
        this.ticksLeft = ticksLeft;
    }
}