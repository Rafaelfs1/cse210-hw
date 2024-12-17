class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor that allows initialization of the goal with all attributes
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Constructor with default amountCompleted set to 0
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Method to record progress in the checklist goal
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Event recorded for {_shortName}! Progress: {_amountCompleted}/{_target}");

        // If the goal is complete, award bonus points
        if (IsComplete())
            Console.WriteLine($"Goal completed! +{_bonus} bonus points earned.");
    }

    // Check if the goal is complete (i.e., if the amount completed reaches the target)
    public override bool IsComplete() => _amountCompleted >= _target;

    // Get the detailed string for the goal
    public override string GetDetailsString() => $"{Status} {_shortName} ({_description}) - Progress: {_amountCompleted}/{_target}";
// Get the string representation of the goal, to store or display it
    public override string GetStringRepresentation() => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    // Method to return the bonus points of the checklist goal
    public int GetBonus() => _bonus; // Return the bonus points
}
