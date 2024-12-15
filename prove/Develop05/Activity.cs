using System;
using System.Threading;


public abstract class Activity
{
    private int duration;

    public abstract void StartActivity();

    public int GetDuration()
    {
        return duration;
    }

    public void DisplayStartMessage(string activityName, string description)
    {
        Console.WriteLine($"\n{activityName}\n{description}\n");
        if(activityName == "Breathing Activity: 4-7-8 Breathing technique")
        {
            Console.WriteLine("Please enter number of repetitions: ");
            duration = int.Parse(Console.ReadLine()); 
        }
        else
        {
            Console.WriteLine("Please enter the duration (in seconds): ");
            duration = int.Parse(Console.ReadLine()); 
        }
        
        Console.WriteLine("Get ready to start...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void DisplayEndMessage(string activityName)
    {
        if(activityName == "Breathing Activity: 4-7-8 Breathing technique")
        {
            Console.WriteLine($"You have completed {activityName} for {duration} Repetitions.");
        }
        else
        {
            Console.WriteLine($"You have completed {activityName} for {duration} seconds.");
        }
        
        Console.WriteLine("Good job!");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void CountdownNumber(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);      
            Thread.Sleep(1000);    
            Console.Write("\b \b"); 
        }
        Console.WriteLine();       
    }
   
    public void Countdown()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void Countdown(int duration)
    {
        int times = duration;
        for (int i = 0; i < times; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

