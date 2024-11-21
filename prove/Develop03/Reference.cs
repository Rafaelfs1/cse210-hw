using System;

public class Reference
{
    private string _book; // The name of the book (e.g., "Proverbs")
    private int _chapter; // The chapter number
    private int _verse; // The starting verse number
    private int? _endVerse; // The ending verse number (optional)

    // Constructor for references with a single verse or a range
    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Returns the reference as a formatted string (e.g., "Proverbs 3:5-6")
    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}
