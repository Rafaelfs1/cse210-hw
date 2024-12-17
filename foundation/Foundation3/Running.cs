using System;

// Derived class for Running activity
public class Running : Activity
{
    private double _distance; // Distance covered during the run in miles

    // Constructor to initialize the Running activity with additional distance
    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    // Override the GetDistance method for Running
    public override double GetDistance() => _distance;

    // Override the GetSpeed method for Running
    public override double GetSpeed() => (GetDistance() / GetDurationInMinutes()) * 60;

    // Override the GetPace method for Running
    public override double GetPace() => GetDurationInMinutes() / GetDistance();
}
