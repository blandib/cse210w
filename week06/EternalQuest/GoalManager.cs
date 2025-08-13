using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void CreateGoal()
{
    Console.WriteLine("Select goal type:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Choice: ");
    string type = Console.ReadLine();

    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter description: ");
    string desc = Console.ReadLine();
    Console.Write("Enter points: ");
    int points = int.Parse(Console.ReadLine());

    if (type == "1")
    {
        _goals.Add(new SimpleGoal(name, desc, points));
    }
    else if (type == "2")
    {
        _goals.Add(new EternalGoal(name, desc, points));
    }
    else if (type == "3")
    {
        Console.Write("Enter target count: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonus = int.Parse(Console.ReadLine());
        _goals.Add(new ChecklistGoal(name, desc, points, 0, target, bonus));
    }
    else
    {
        Console.WriteLine("Invalid goal type.");
    }
}

    public void Start()
    {
        string choice = "";
        while (choice != "8")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
         
            switch (choice)
            {
                case "1": DisplayPlayerInfo(); break;
                case "2": ListGoalNames(); break;
                case "3": ListGoalDetails(); break;
                case "4": CreateGoal(); break;
                case "5": RecordEvent(); break;
                case "6": SaveGoals(); break;
                case "7": LoadGoals(); break;
                case "8": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    public void ListGoalDetails()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("No goals to display.");
        return;
    }

    foreach (var goal in _goals)
    {
        Console.WriteLine(goal.GetDetailsString());
    }
}


    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

   public void LoadGoals()
{
    if (!File.Exists("goals.txt"))
    {
        Console.WriteLine("No saved goals found.");
        return;
    }

    string[] lines = File.ReadAllLines("goals.txt");
    _score = int.Parse(lines[0]);
    _goals.Clear();

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(",");
        string goalType = parts[0];

        if (goalType == "SimpleGoal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            _goals.Add(new SimpleGoal(name, desc, points, isComplete));
        }
        else if (goalType == "EternalGoal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (goalType == "ChecklistGoal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            int completed = int.Parse(parts[4]);
            int target = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            _goals.Add(new ChecklistGoal(name, desc, points, completed, target, bonus));
        }
    }

    Console.WriteLine("Goals loaded.");
}

    
}
