using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public override void StartActivity()
    {
        DisplayStartMessage("Listing Activity", "This activity will help you reflect on the good things in your life by listing things related to a certain prompt.");
        
        var prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        Countdown();

        int count = 0;
        Console.WriteLine("Start listing... Press Enter after each item.");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                count++;
            }
        }
        Console.WriteLine($"You listed {count} items.");
        DisplayEndMessage("Listing Activity");
    }
}

