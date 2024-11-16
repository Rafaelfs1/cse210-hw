using System;


class Journal
{   
    // colect the entries in list
    public List<string> _entries = new List<string>();

    // set the function to operate the code
    public void AddEntry()
    {   
        // get the current date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator();
        // Get a random prompt
        string randomPrompt = promptGenerator.GetRandomPrompt();

        // Display this prompt
        Console.WriteLine($"Prompt: {randomPrompt}");
        string userEntry = Console.ReadLine();

        // Prepare the entry
        Entry NewEntry = new Entry
        {
            _date = $"Date: {dateText}", 
            _promptText = $"Prompt: {randomPrompt}",
            _entryText = userEntry  
        };
                
        _entries.Add(NewEntry._date + "," + NewEntry._promptText + "," + NewEntry._entryText);
    }

    public void DisplayAll()
    {
        foreach (string entry in _entries)
        {
            // split the entry
            string[] entryArray = entry.Split(",");

            string _date = entryArray[0];
            string _promptText = entryArray[1];
            string _entryText = entryArray[2];

            // display the entry line by line
            Console.WriteLine(_date);
            Console.WriteLine(_promptText);
            Console.WriteLine(_entryText);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void SaveToFile()
    {
        // prepare the filename 
        Console.Write("Enter the filename to save the entries: ");
        string fName = Console.ReadLine();
        string fileName = $"{fName}.txt";

        System.IO.File.WriteAllLines(fileName, _entries);
    }

    public void LoadFromFile()
    {
        // get the filename from user
        Console.Write("Enter the filename to load: ");
        string fName = Console.ReadLine(); 
        string filename = $"{fName}.txt";

        // load the file
        string[] lines = System.IO.File.ReadAllLines(filename);

        // torn the lines into entries
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];

            // create the entry
            Entry NewEntry = new Entry
            {
                _date = _date, 
                _promptText = _promptText,
                _entryText = _entryText
            };
            
            _entries.Add(NewEntry._date + "," + NewEntry._promptText + "," + NewEntry._entryText);
        }

        // confirmation of the load
        Console.WriteLine("Journal loaded.");
        Console.WriteLine();
    }
}