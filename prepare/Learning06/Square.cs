using System;

public class Square : Shape
{
    private double _side;

    public double GetSide()
    {
        return _side;
    }

    public double SetSide(double side)
    {
        return _side = side;
    }

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
    
}