using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean endGame = false;
        int activitiesDone = 0;
        while (!endGame)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartActivity();
                    breathing.Run();
                    activitiesDone++;
                    break;
                case "2":
                    ReflectionActivity reflecting = new ReflectionActivity();
                    reflecting.StartActivity();
                    reflecting.Run();
                    activitiesDone++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.StartActivity();
                    listing.Run();
                    activitiesDone++;
                    break;
                case "4":
                    Console.WriteLine("You did " + activitiesDone + " activities.");
                    Console.WriteLine("Goodbye!");
                    endGame = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}