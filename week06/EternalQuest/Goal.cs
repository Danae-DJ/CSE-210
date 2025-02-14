//Goal.cs:father
using System;

public abstract class Goal
{//private or pretected???
    protected string _shortName; //Its accessible now
    protected string _description;
    protected int _points;

    public Goal( string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}


//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected