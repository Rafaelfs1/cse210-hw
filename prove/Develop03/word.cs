using System;

public class Word
{
    private string _text; // The actual word text
    private bool _isHidden; // Indicates whether the word is hidden

    // Constructor to initialize the word with its text and set it as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word by setting _isHidden to true
    public void Hide()
    {
        _isHidden = true;
    }

    // Reveals the word by setting _isHidden to false
    public void Show()
    {
        _isHidden = false;
    }

    // Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the display text of the word (hidden words are shown as underscores)
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
