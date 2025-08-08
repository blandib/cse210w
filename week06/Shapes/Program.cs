using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        // Create a Square instance with color "Blue" and side length 5
        Square mySquare = new Square("Blue", 5);

        // Get and print the color
        Console.WriteLine("Color: " + mySquare.Color);  

        // Get and print the area
        Console.WriteLine("Area: " + mySquare.GetArea());  
        
    }
}