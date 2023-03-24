using System.IO;

public class Game
{
    private int _points;
    private List<Goal> _goals = new List<Goal>();

    private void AddPoints(int points)
    {
        _points += points;
    }

    private string HaveUserSelectOption()
    {
        Console.Clear();
        Console.WriteLine("You have " + _points + " points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    private void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.WriteLine("Which type of goal do you want to create? ");
        string choice = "0";

        while (choice != "1" && choice != "2" && choice != "3")
        {
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("What is the name of your goal?: ");
                string name = Console.ReadLine();

                Console.WriteLine("What is a short description of it?: ");
                string description = Console.ReadLine();

                Console.WriteLine("How many points is it worth?: ");
                int worth = Convert.ToInt32(Console.ReadLine());

                SimpleGoal goal = new SimpleGoal(name, description, worth);
                _goals.Add(goal);
            }
            else if (choice == "2")
            {
                Console.WriteLine("What is the name of your goal?: ");
                string name = Console.ReadLine();

                Console.WriteLine("What is a short description of it?: ");
                string description = Console.ReadLine();

                Console.WriteLine("How many points is it worth?: ");
                int worth = Convert.ToInt32(Console.ReadLine());

                EternalGoal goal = new EternalGoal(name, description, worth);
                _goals.Add(goal);
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the name of your goal?: ");
                string name = Console.ReadLine();

                Console.WriteLine("What is a short description of it?: ");
                string description = Console.ReadLine();

                Console.WriteLine("How many points is it worth?: ");
                int worth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many bonus points do you get for completing it?: ");
                int bonus = Convert.ToInt32(Console.ReadLine());

                ChecklistGoal goal = new ChecklistGoal(name, description, worth, amount, bonus);
                _goals.Add(goal);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        }
    }

    private void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        int index = 0;
        foreach (Goal goal in _goals)
        {
            index++;
            Console.WriteLine(index + ". " + goal.DisplayGoal());
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    private void SaveGoals()
    {
        Console.WriteLine("What is the name of the file you want to save to?: ");
        string fileName = Console.ReadLine();
        StreamWriter writer = new StreamWriter(fileName);
        writer.WriteLine(_points);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.SaveGoal());
        }
        writer.Close();
    }

    private void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load from?: ");
        string fileName = Console.ReadLine();
        StreamReader reader = new StreamReader(fileName);
        _points = Convert.ToInt32(reader.ReadLine());
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] parts = line.Split('|');
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                // ChecklistGoal|Eat breakfast|Healthy meals|10|False|7|0|25
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(goal);
            }
        }
        reader.Close();
    }

    private void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        int index = 0;
        foreach (Goal goal in _goals)
        {
            index++;
            Console.WriteLine(index + ". " + goal.DisplayGoal());
        }
        Console.WriteLine("Which goal do you want to record an event for?: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice > 0 && choice <= _goals.Count)
        {
            _goals[choice - 1].CompleteGoal();
            AddPoints(_goals[choice - 1].GetWorth());
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void Run()
    {
        string choice = HaveUserSelectOption();
        while (choice != "6")
        {
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                default:
                    break;
            }
            choice = HaveUserSelectOption();
        }
    }
}