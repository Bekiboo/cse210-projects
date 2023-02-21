using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        int score = int.Parse(Console.ReadLine());
        int lastDigit = score % 10;
        string sign = "";

        Console.WriteLine($"Last Digit is {lastDigit}.");

        if (lastDigit < 3)
        {
            sign = "-";
        }
        else if (lastDigit > 7 && score < 90)
        {
            sign = "+";
        }

        if (score >= 90)
        {
            Console.WriteLine($"You got an A{sign}!");
        }
        else if (score >= 80)
        {
            Console.WriteLine($"You got a B{sign}!");
        }
        else if (score >= 70)
        {
            Console.WriteLine($"You got a C{sign}!");
        }
        else if (score >= 60)
        {
            Console.WriteLine($"You got a D{sign}!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }
    }
}