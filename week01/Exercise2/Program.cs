using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        // Determine the letter grade
        char grade;
        if (score >= 90)
            grade = 'A';
        else if (score >= 80)
            grade = 'B';
        else if (score >= 70)
            grade = 'C';
        else if (score >= 60)
            grade = 'D';
        else
            grade = 'F';

        Console.WriteLine($"Your letter grade is: {grade}");

        // Determine pass/fail and display appropriate message
        if (score >= 70)
        {
            Console.WriteLine(" Congratulations! You passed the course. Great job!");
        }
        else
        {
            Console.WriteLine(" Don't give up! Study hard and you'll do better next time.");
        }
    }
}

    
