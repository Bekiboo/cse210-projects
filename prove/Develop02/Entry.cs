using System;

public class Entry
{
    public Entry(string prompt, string userEntry)
    {
        _prompt = prompt;
        _userEntry = userEntry.Replace(",", "|");
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }
    public string _userEntry;
    public string _prompt;
    public string _date;
    // public List<string> _entryList;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_userEntry);
    }
}