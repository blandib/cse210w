using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Menu menu = new Menu();
        menu.Start();
        /*Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Writing a new journal entry...");
        string prompt = promptGen.GetRandomPrompt();

        Console.WriteLine("prompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(date, prompt, response);
        myJournal.AddEntry(newEntry);
        Console.WriteLine("\nAll journal entries:\n");
        myJournal.DisplayAll();*/
    }
}