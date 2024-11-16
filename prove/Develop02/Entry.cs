using System;


public class Entry
{
    // set the variable strings
    public string _date;
    public string _promptText;
    public string _entryText;

    // Dsiplay the values 
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText} - {_entryText}");
        
    }

    
}