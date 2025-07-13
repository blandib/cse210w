using System;
using System.Collections.Generic;


class Menu
{
    private Journal myJournal = new Journal();
    private PromptGenerator promptGen = new PromptGenerator();

    public void Start()
    {
        string choice = "";
        while (choice != "5") 
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine("Prompt: " + prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(date, prompt, response);
                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    myJournal.SaveToFile("journal.txt");
                    break;
                case "4":
                     Console.Write("Enter filename to load: ");
                     string filename = Console.ReadLine();
                     myJournal.LoadFromFile(filename);
                     Console.WriteLine("Journal loaded.");
                    break;


                case "5":
                    Console.WriteLine("Exiting journal. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
