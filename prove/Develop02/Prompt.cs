using System;

public class Prompt
{
    public string _prompt;
    public void RandomPrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("What was the best part of my day?");
        promptList.Add("What was the worst part of my day?");
        promptList.Add("What was the most interesting person I interacted with today?");
        promptList.Add("How did I see the hand of the Lord in my life today?");
        promptList.Add("What was the strongest emotion I felt today?");
        promptList.Add("If I had one thing I could do over today, what would it be?");
        
        Random random = new Random();
        int index = random.Next(promptList.Count);
        _prompt = promptList[index];
        Console.WriteLine(_prompt);
    }

}