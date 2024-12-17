using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {_shortName}! +{_points} points earned.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"{Status} {_shortName} ({_description}) - Ongoing";

    public override string GetStringRepresentation() => $"EternalGoal|{_shortName}|{_description}|{_points}";
}
