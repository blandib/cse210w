using System;
// Define the Circle class that inherits from Shape
public class Circle : Shapes
{
    // Private member variable for radius
    private double _radius;

    // Constructor that accepts color and radius
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method to calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
