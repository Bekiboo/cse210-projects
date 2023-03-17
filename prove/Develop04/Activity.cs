using System;

public class Activity
{

    private string _name;
    private string _description;
    private int _duration;
    private int _spinnerCounter;

    // public Activity()
    // {
    // }

    public void setDuration(int duration)
    {
        _duration = duration;
    }

    public int getDuration()
    {
        return _duration;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public void setDescription(string description)
    {
        _description = description;
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + " Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int.TryParse(Console.ReadLine(), out _duration);
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        DisplaySpinner(3);
        Console.WriteLine("You have completed another " + _duration + " seconds of the " + _name + " activity.");
        DisplaySpinner(3);
    }
}