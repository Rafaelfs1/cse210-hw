using System; 
using System.Collections.Generic; // For List
using System.Linq; // For Selector

class Scripture
{
    private Reference _reference; // Holds the scripture reference 
    private List<Word> _words; // Stores the scripture text as a list of Word objects

    // Constructor to initialize the scripture with its reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        SetScripture(text);
    }

    // Splits the provided text into words and stores them as Word objects
    public void SetScripture(string text)
    {
        // Split the scripture text into words
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList(); 
       

    }
    // Hides a specified number of random words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Continue hiding words until the specified number is reached
        while (hiddenCount < numberToHide && _words.Any(w => !w.IsHidden()))
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    // Returns the scripture text as a single string, including hidden words as underscores
    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {text}";
    }

    // Checks if all words in the scripture are completely hidden
    public bool isCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
