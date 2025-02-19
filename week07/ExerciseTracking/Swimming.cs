//Swimming.cs: derived.cs
using System;

public class Swimming: Activity
{
    private int _lap;
    
    public Swimming(string date, int duration, int laps)
    : base(date, duration)
    {
        _lap = laps;
    }

    public override double GetDistance()
    {
       return (_lap * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return (DurationInMinutes / GetDistance());
    }
}