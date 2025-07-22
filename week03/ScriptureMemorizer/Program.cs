using System;

class Program
{
    static void Main(string[] args)
    {
        // Stretch Features:
        // - Scripture library with random selection.
        // - Hint system to reveal one hidden word.

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // 1. Create a scripture library
        List<Scripture> scriptureLibrary = new List<Scripture>
    {
        new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
        new Scripture(new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        new Scripture(new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy.")
    };

        // 2. Randomly select one scripture
        Random rand = new Random();
        Scripture scripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];
        Hider hider = new Hider();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue, type 'hint' for help, or 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.RevealOneHiddenWord(); 
            }
            else
            {
                hider.HideWords(scripture, 3); 
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}