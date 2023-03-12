using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignement mathAssignement = new MathAssignement("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(mathAssignement.GetSummary());
        Console.WriteLine(mathAssignement.GetHomeworkList());

        WritingAssignement writingAssignement = new WritingAssignement("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(writingAssignement.GetSummary());
        Console.WriteLine(writingAssignement.GetWritingInformation());
    }
}