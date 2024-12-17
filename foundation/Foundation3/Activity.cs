using System;

// Abstract base class for all activities
public abstract class Activity
{
    private DateTime _date; // Date of the activity
    private int _durationInMinutes; // Duration of the activity in minutes

    // Constructor to initialize the activity with date and duration
    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    // Getter methods for the properties
    public DateTime GetDate() => _date;
    public int GetDurationInMinutes() => _durationInMinutes;

    // Abstract methods that must be implemented by derived classes
    public abstract double GetDistance(); // To be overridden by derived classes
    public abstract double GetSpeed(); // To be overridden by derived classes
    public abstract double GetPace(); // To be overridden by derived classes

    // Method to return a summary of the activity
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_durationInMinutes} min): Distance {GetDistance():0.0}, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
