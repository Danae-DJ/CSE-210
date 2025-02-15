//EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    private int _timeRecorded; 
    public EternalGoal(string name, string description, int points)
    : base(name, description, points)
    {
        _timeRecorded = 0; 
    }

    public override void RecordEvent()
    {
        _timeRecorded++;
        Console.WriteLine($"Nice! You earned {Points} points! (Recorded {_timeRecorded} times).");
    }


    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {ShortName}: {Description} (Complete {_timeRecorded} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{ShortName}|{Description}|{Points}|{_timeRecorded}";
    }

}