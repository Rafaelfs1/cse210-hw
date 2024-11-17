using System;

class Fraction
{   
    // instance variables
    private int _top;
    private int _bottom;

    // constructor ---------------------------------------------------
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
       _top = wholeNumber;
       _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //  methods -----------------------------------------------------
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        top = _top;
    }


    public int GetBottom() 
    {
        return _bottom;
    }


    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}