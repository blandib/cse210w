using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        bool useMetric = false; // toggle between miles and km

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 8, 13), 30, 4.8),
            new Cycling(new DateTime(2025, 8, 13), 30, 9.7),
            new Swimming(new DateTime(2025, 8, 13), 30, 60)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary(useMetric));
        }
    }
}