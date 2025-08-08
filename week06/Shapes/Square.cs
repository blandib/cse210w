using System;
// Define the Square class that inherits from Shape
public class Square : Shapes
{
    // Private member variable to store the side length
    private double _side;

    // Constructor that accepts color and side length
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea method to calculate the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}
