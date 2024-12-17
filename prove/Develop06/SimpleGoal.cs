using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Event recorded for {_shortName}! +{_points} points earned.");
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"{Status} {_shortName} ({_description})";

    public override string GetStringRepresentation() => $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";

}
