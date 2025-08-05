using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        // Create an instance of Assignment
        Assignment myAssignment = new Assignment("Blandine Bukasa", "Backend Development");

        // Call GetSummary and display the result
        Console.WriteLine(myAssignment.GetSummary());

        // Create a MathAssignment object
        //MathAssignment mathAssignment = new MathAssignment("Blandine Bukasa", "Algebra", "7.3", "1-10");

        // Test GetSummary from base class
        //Console.WriteLine(mathAssignment.GetSummary());

        // Test GetHomeworkList from derived class
        // MathAssignment test
        MathAssignment mathAssignment = new MathAssignment("Blandine Bukasa", "Algebra", "7.3", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // WritingAssignment test
        WritingAssignment writingAssignment = new WritingAssignment("Blandine Bukasa", "Literature", "The Power of Grace");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}