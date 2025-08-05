using System;
public class BreathingActivity : Activity
{
    private List<string> messages = new List<string> { "Breathe in...", "Breathe out..." };

    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        StartMessage();
        int elapsed = 0;
        while (elapsed < duration)
        {
            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
                ShowCountdown(3);
                elapsed += 3;
                if (elapsed >= duration) break;
            }
        }
        EndMessage();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
