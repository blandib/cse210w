using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(2000);
                    continue;
            }

            activity.Run();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
    
