using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
       // Create a list to hold shapes
        List<Shapes> shapes = new List<Shapes>();

        // Add a square, rectangle, and circle to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Iterate through the list and display color and area
        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
        // Create a Square instance with color "Blue" and side length 5
        /*Square mySquare = new Square("Blue", 5);

        // Get and print the color
        Console.WriteLine("Color: " + mySquare.Color);

        // Get and print the area
        Console.WriteLine("Area: " + mySquare.GetArea());  
         // Create and test a Rectangle
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle - Color: {rectangle.Color}, Area: {rectangle.GetArea()}");

        // Create and test a Circle
        Circle circle = new Circle("Green", 2.5);
        Console.WriteLine($"Circle - Color: {circle.Color}, Area: {circle.GetArea():F2}");*/
    }
        
    }
