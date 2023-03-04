using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Prompt prompt = new Prompt();
        Journal journal = new Journal();

        static string askForAction()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string action = Console.ReadLine();
            return action;
        }

        string action = "";

        while (action != "5")
        {
            action = askForAction();
            switch (action)
            {
                case "1": // Write
                    Console.WriteLine("Write");
                    prompt.RandomPrompt();
                    Entry entry = new Entry(prompt._prompt, Console.ReadLine());
                    journal._entries.Add(entry);
                    break;
                case "2": // Display
                    journal.DisplayEntries();
                    break;
                case "3": // Load
                    Console.WriteLine("What is the filename?");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "4": // Save
                    Console.WriteLine("What is the filename?");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "5": // Quit
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }

    }
}