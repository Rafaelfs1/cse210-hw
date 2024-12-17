using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of activities
        var activities = new List<Activity>
        {
            // Adding one activity of each type to the list
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 15.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        // Iterate over the activities and display a summary for each one
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary()); // Calls GetSummary method to display the details
        }
    }
}
