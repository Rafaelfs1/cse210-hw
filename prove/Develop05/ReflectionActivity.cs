using System;
using System.Collections.Generic;


public class ReflectionActivity : Activity
{
    private static readonly List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public override void startActivity()
    {
        displayStartMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        
        var prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine(prompt);
        countdown();
        
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            countdown();
        }

        displayEndMessage("Reflection Activity");
    }
}

