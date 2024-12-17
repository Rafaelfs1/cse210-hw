using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Save goals to file");
            Console.WriteLine("5. Load goals from file");
            Console.WriteLine("6. Delete a goal");
            Console.WriteLine("7. Quit");

            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalsDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoalsToFile(); break;
                case "5": LoadGoalsFromFile(); break;
                case "6": DeleteGoal(); break;
                case "7": Console.WriteLine("Exiting... Goodbye!"); return;
                default: Console.WriteLine("Invalid choice. Please try again."); break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou currently have {_score} points.\n");
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoalsDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record events for.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("\nEnter the goal number: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();

            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetPoints(); // Add bonus for checklist goals
            }

            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    private void DeleteGoal()
    {
        // If there are no goals, inform the user and return
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to delete.");
            return;
        }

        // Show the user a list of their goals
        Console.WriteLine("\nSelect a goal to delete:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()} - {_goals[i].GetDetailsString()}");
        }

        // Prompt the user to choose a goal to delete
        Console.Write("\nEnter the goal number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            
            // If the goal is complete, deduct its points from the total score
            if (selectedGoal.IsComplete())
            {
                _score -= selectedGoal.GetPoints();
                if (_score < 0)
                {
                    _score = 0; // Prevent score from going negative
                }
                Console.WriteLine($"Points deducted: {selectedGoal.GetPoints()}");
            }

            // If the goal is a ChecklistGoal and it is complete, subtract the bonus points
            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score -= checklistGoal.GetBonus(); // Subtract the bonus points of the completed goal
                if (_score < 0)
                {
                    _score = 0; // Prevent score from going negative
                }
                Console.WriteLine($"Bonus points deducted: {checklistGoal.GetBonus()}");
            }

            // Remove the goal from the list after deleting
            _goals.RemoveAt(goalIndex - 1);

            // Inform the user of the updated score after deletion
            Console.WriteLine($"Goal '{selectedGoal.GetShortName()}' has been deleted.");
            Console.WriteLine($"Updated score: {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid selection. No goal was deleted.");
        }
    }

    private void SaveGoalsToFile()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoalsFromFile()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please try again.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                    break;
                default:
                    Console.WriteLine($"Unknown goal type on line {i + 1}. Skipping...");
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully!");
        
    }
}
