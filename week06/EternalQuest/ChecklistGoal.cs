//CheklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}