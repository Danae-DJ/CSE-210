//SimpleGoal.cs(child)
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal( bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}