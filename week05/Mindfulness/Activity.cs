using System;
public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name}!");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
