using System;

class Program
{
    static void Main(string[] args)
    {
        // declare variables
        int menuEntry = -1;

        // create instances
        Journal journal = new Journal();

        // this loop will run until the user chooses to quit
        while (menuEntry != 5)
        {
            // display the menu
            Console.WriteLine("Please select one of the following choices:\r\n1 - Write\r\n2 - Display\r\n3 - Load\r\n4 - Save\r\n5 - Quit");
            Console.Write("What would you like to do? ");

            // get the entry chosen by the user
            menuEntry = int.Parse(Console.ReadLine());

            // handle menu options ---------------------------------------------
            // 1 - Write
            if (menuEntry == 1)
            {
                journal.AddEntry();
            }
            // 2 - Display
            else if (menuEntry == 2)
            {
                journal.DisplayAll();
            }
            // 3 - Load 
            else if (menuEntry == 3)
            {
                journal.LoadFromFile();
            }
            // 4 - Save 
            else if (menuEntry == 4)
            {
                journal.SaveToFile();
            }
            // 5 - Quit (loop will exit)
            else if (menuEntry == 5)
            {
                Console.WriteLine("Goodbye!");
            }

        }

    }

}