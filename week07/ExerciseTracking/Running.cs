//Running.cs: derived
using System;
public class Running: Activity
{
    private double _distance;
    public Running(string date, int duration, double distance)
    : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
       return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / DurationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return (DurationInMinutes / _distance);
    }
}


/*The formula for Speed is given as 
[Speed = Distance ÷ Time]. 
To calculate the distance, 
the speed formula can be molded 
as [Distance = Speed × Time].*/

//https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-7.php
//https://stackoverflow.com/questions/36315622/using-a-mathematical-formula-to-define-player-speed 