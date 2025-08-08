using System;
// Define the Rectangle class that inherits from Shape
public class Rectangle : Shapes
{
    // Private member variables for width and height
    private double _width;
    private double _height;
    // Constructor that accepts color, width, and height
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }
     // Override the GetArea method to calculate the area of the rectangle
    public override double GetArea()
    {
        return _width * _height;
    }
}