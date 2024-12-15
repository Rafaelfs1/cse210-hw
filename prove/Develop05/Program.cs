using System;


class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            // Display menu
            Console.Clear();
            Console.WriteLine(
                "Mindfulness App\n" +
                "  1. Start Breathing Activity\n" +
                "  2. Start Reflection Activity\n" +
                "  3. Start Listing Activity\n" +
                "  4. Quit"                 
            );
            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();

            Activity activity = null;

            // Create activity based on user choice
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    Thread.Sleep(2000);
                    continue;
            }

            // Start activity
            if (activity != null)
            {
                activity.StartActivity();
            }
        }
    }
}

