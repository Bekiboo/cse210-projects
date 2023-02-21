using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int? newNumber = null;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                break;
            }
            numbers.Add((int)newNumber);
        }

        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {numbers.Where(n => n > 0).Min()}");

        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}