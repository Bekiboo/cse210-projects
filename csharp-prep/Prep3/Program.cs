using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int? guess = null;
        int attempts = 0;
        bool newGame = true;

        while (guess != magicNumber || newGame)
        {
            if (newGame)
            {
                magicNumber = randomGenerator.Next(1, 11);
                guess = null;
                attempts = 0;
                newGame = false;
            }
            if (guess != null && guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess != null && guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }

            Console.Write("Guess the magic number? ");
            guess = int.Parse(Console.ReadLine());

            attempts++;

            if (guess == magicNumber)
            {
                Console.WriteLine($"You guessed it in only {attempts} attempts!");
                Console.Write("Play again? (y/n) ");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    newGame = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }


    }
}