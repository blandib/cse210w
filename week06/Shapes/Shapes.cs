using System;
// Define the Shape class
public class Shapes
{
    // Member variable to store the color of the shape
    private string color;

    // Getter and setter for the color property
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Constructor that accepts a color and sets it
    public Shapes(string color)
    {
        this.color = color;
    }

    // Virtual method to calculate the area of the shape
    // This can be overridden by derived classes
    public virtual double GetArea()
    {
        // Base class doesn't define a specific shape, so return 0
        return 0;
    }
    public string GetColor()
    {
        return color;
    }
}
