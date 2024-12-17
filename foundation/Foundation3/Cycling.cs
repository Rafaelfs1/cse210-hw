using System;

// Derived class for Cycling activity
public class Cycling : Activity
{
    private double _speed; // Speed during the cycling activity in miles per hour

    // Constructor to initialize the Cycling activity with additional speed
    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    // Override the GetDistance method for Cycling
    public override double GetDistance() => _speed * GetDurationInMinutes() / 60;

    // Override the GetSpeed method for Cycling
    public override double GetSpeed() => _speed;

    // Override the GetPace method for Cycling
    public override double GetPace() => 60 / _speed;
}
