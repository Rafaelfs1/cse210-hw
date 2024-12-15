using System;
using System.Collections.Generic;


public class ReflectionActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public override void StartActivity()
    {
        DisplayStartMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        
        var prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        Countdown();
        
        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Countdown();
        }

        DisplayEndMessage("Reflection Activity");
    }
}

