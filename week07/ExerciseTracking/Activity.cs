//Activiity.cs: Base
using System;

public abstract class Activity
{
    private string _date;
    private int _durationInMinutes;
    public Activity(string date, int duration)
    {
        _date = date;
        _durationInMinutes = duration;
    }

    public string Date => _date;
    public int DurationInMinutes => _durationInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();//?
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min/km";
    }
}
//formule
//:F2 (decimals)