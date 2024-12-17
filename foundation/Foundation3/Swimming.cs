using System;

// Derived class for Swimming activity
public class Swimming : Activity
{
    private int _laps; // Number of laps swum in the pool

    // Constructor to initialize the Swimming activity with laps
    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    // Override the GetDistance method for Swimming (calculating in kilometers)
    public override double GetDistance() => _laps * 50 / 1000.0; // Distance in kilometers

    // Override the GetSpeed method for Swimming
    public override double GetSpeed() => (GetDistance() / GetDurationInMinutes()) * 60;

    // Override the GetPace method for Swimming
    public override double GetPace() => GetDurationInMinutes() / GetDistance();
}
