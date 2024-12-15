using System;
using System.Threading;


public abstract class Activity
{
    private int _duration;

    public abstract void startActivity();

    public int getDuration()
    {
        return _duration;
    }

    public void displayStartMessage(string activityName, string description)
    {
        Console.WriteLine($"\n{activityName}\n{description}\n");
        if(activityName == "Breathing Activity: 4-7-8 Breathing technique")
        {
            Console.WriteLine("Please enter number of repetitions: ");
            _duration = int.Parse(Console.ReadLine()); 
        }
        else
        {
            Console.WriteLine("Please enter the duration (in seconds): ");
            _duration = int.Parse(Console.ReadLine()); 
        }
        
        Console.WriteLine("Get ready to start...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void displayEndMessage(string activityName)
    {
        if(activityName == "Breathing Activity: 4-7-8 Breathing technique")
        {
            Console.WriteLine($"You have completed {activityName} for {_duration} Repetitions.");
        }
        else
        {
            Console.WriteLine($"You have completed {activityName} for {_duration} seconds.");
        }
        
        Console.WriteLine("Good job!");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void countdownNumber(int _duration)
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);      
            Thread.Sleep(1000);    
            Console.Write("\b \b"); 
        }
        Console.WriteLine();       
    }
   
    public void countdown()
    {
        for (int i = 0; i < _duration; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void countdown(int _duration)
    {
        int times = _duration;
        for (int i = 0; i < times; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

