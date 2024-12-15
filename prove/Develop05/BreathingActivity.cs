using System;


public class BreathingActivity : Activity
{
    public override void startActivity()
    {
        displayStartMessage("Breathing Activity: 4-7-8 Breathing technique", "\nThe 4-7-8 breathing technique is a simple relaxation method that helps reduce stress and promote calmness. \nIt involves inhaling through the nose for 4 seconds, holding the breath for 7 seconds, and exhaling slowly through the mouth for 8 seconds. \nThis practice is often used to manage anxiety, improve focus, and aid in falling asleep.");

        // Initial instructions
        Console.WriteLine("Instructions:\n" +
                            "1. Exhale completely through your mouth.\n" +
                            "2. Inhale through your nose for 4 seconds.\n" +
                            "3. Hold your breath for 7 seconds.\n" +
                            "4. Exhale through your mouth for 8 seconds.\n" +
                            "Repeat this 4 times.");
        Console.WriteLine("\nGet ready to begin...");
        countdown(5); // Countdown before starting
        Console.WriteLine("\nLet's start!");
        Thread.Sleep(1000);

        // Run the activity
        run(getDuration());
        
        // End the activity
        displayEndMessage("4-7-8 Breathing");
        Thread.Sleep(2000);
        
      
    }

    public void run(int _duration)
    {
        for (int i = 0; i < _duration; i++)
        {
        

        // Phase 1 - Exhale completely
        Console.WriteLine("Exhale completely through your mouth...");
        countdown();
        Console.WriteLine("Now, get ready to inhale.");

        // Phase 2 - Inhale for 4 seconds
        Console.WriteLine("Inhale through your nose for 4 seconds.");
        countdownNumber(4);

        // Phase 3 - Hold your breath for 7 seconds
        Console.WriteLine("Hold your breath for 7 seconds.");
        countdownNumber(7);

        // Phase 4 - Exhale for 8 seconds
        Console.WriteLine("Exhale through your mouth for 8 seconds.");
        countdownNumber(8);
        }
    }
}

