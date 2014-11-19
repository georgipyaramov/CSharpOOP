using System;
using System.Threading;

public class Timer
{
    public event TimeElapsedEventHandler TimeElapsed;

    private int ticksCount;
    private int interval;

    public int TicksCount
    {
        get
        {
            return this.ticksCount;
        }
    }

    public int Interval
    {
        get
        {
            return this.interval;
        }
    }

    public Timer(int ticksCount, int interval)
    {
        this.ticksCount = ticksCount;
        this.interval = interval;
    }

    protected void OnTimeElapsed(int ticks)
    {
        if (TimeElapsed != null)
        {
            TimeElapsedEventArgs e = new TimeElapsedEventArgs(ticks);
            TimeElapsed(this, e);
        }
    }

    public void Run()
    {
        int ticks = this.ticksCount;
        while (ticks > 0)
        {
            Thread.Sleep(this.interval);
            ticks--;
            OnTimeElapsed(ticks);
        }
    }

    static void Main()
    {
        int ticksCount = 10;
        int interval = 2000; 
        Timer timer = new Timer(ticksCount, interval);
        timer.TimeElapsed += new TimeElapsedEventHandler(timer_TimeElapsed);

        Console.WriteLine("Timer started for {0} ticks, a tick occurring once every {1} second(s).", ticksCount, interval / 1000);

        Thread timerThread = new Thread(new ThreadStart(timer.Run));
        timerThread.Start();
    }

    static void timer_TimeElapsed(object sender, TimeElapsedEventArgs e)
    {
        Console.WriteLine("Timer interval has elapsed. Ticks left: {0}.", e.TicksLeft);
    }
}