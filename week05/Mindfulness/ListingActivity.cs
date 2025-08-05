using System;
public class ListingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> responses = new List<string>();

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
    }

    public override void Run()
    {
        StartMessage();
        Console.WriteLine(prompts[new Random().Next(prompts.Count)]);
        Console.WriteLine("You will begin listing in 3 seconds...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("→ ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
                responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        EndMessage();
    }
}
