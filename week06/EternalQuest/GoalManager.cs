//GoalManager.cs
using System;

public class GoalManager() : Goal
{
    _goals = new Lazy<Goal>();
    _score = 0;
}