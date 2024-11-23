using System;
using System.Collections.Generic;

// was add more scriptures with ramdom choice in the beginning 
// Create a list of scripture options from the Bible and Book of Mormon
// Each scripture is defined with a reference (book, chapter, verse) and a text
// Select a random scripture from the list

class Program
{


    static void Main(string[] args)
    {
        
        // Create a list of scripture options from the Bible and Book of Mormon
        
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all your heart and lean not on your understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness.")
        };

        // Select a random scripture from the list
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];// select a random scripture from the list

        // Display and interact with the selected scripture
        while (!selectedScripture.isCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Hide a few random words
            selectedScripture.HideRandomWords(3);
        }

        // Final display when all words are hidden
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Program complete.");
    }
}
