using System;


public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height, string color) : base(color)
    {
        _width = width;
        _height = height;
    }

    public double GetWidth()
    {
        return _width;
    }

    public double GetHeight()
    {
        return _height;
    }

    public double SetWidth(double width)
    {
        return _width = width;
    }

    public double SetHeight(double height)
    {
        return _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}