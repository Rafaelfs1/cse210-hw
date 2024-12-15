using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>(); 

        // Add shapes to the list
        Circle circle = new Circle(5.0,"Red");
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle(10.0, 20.0, "Blue");
        shapes.Add(rectangle);

        Square square = new Square(15.0, "Green");
        shapes.Add(square);
        
        // Display the area of each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea():F2}.");
        }
    }
}