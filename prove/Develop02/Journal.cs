using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                string savedEntry = parts[1];
                Entry entry = new Entry(parts[0], savedEntry.Replace("|", ","));
                entry._date = parts[2];
                _entries.Add(entry);
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._prompt},{entry._userEntry},{entry._date}");
            }
        }
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}