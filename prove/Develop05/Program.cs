using System;
// added a real breathing activity that has a countdown for 4-7-8 sytem that provides results agaist anxiety, along the user to enter a number of repetitions and then the program will run that many times.

class Program
{
    static void Main(string[] args)
    {
        bool _running = true;

        while (_running)
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

            string _choice = Console.ReadLine();

            Activity _activity = null;

            // Create activity based on user choice
            switch (_choice)
            {
                case "1":
                    _activity = new BreathingActivity();
                    break;
                case "2":
                    _activity = new ReflectionActivity();
                    break;
                case "3":
                    _activity = new ListingActivity();
                    break;
                case "4":
                    _running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    Thread.Sleep(2000);
                    continue;
            }

            // Start activity
            if (_activity != null)
            {
                _activity.startActivity();
            }
        }
    }
}

