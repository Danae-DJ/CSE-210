//step4: Journal.cs: operations to entrys in to file
using System.IO; //for file operations...
public class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            { //Extra: mood and tags
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}|{entry._tags}");
            }
        }
    }


    public void LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2],
                _mood = parts[3], //extra
                _tags = parts[4] //extra
            };
            _entries.Add(entry);
        }
    }




    //Extra: Add a Method to Provide Statistics

    public void GetStatistics()
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No entries available to calculate statistics.");
        return;
    }

    // Total number of entries
    int totalEntries = _entries.Count;

    // Most common mood
    var moodGroups = _entries.GroupBy(entry => entry._mood);
    var mostCommonMood = moodGroups
        .OrderByDescending(group => group.Count())
        .FirstOrDefault()?.Key ?? "None";

    // Earliest and latest entries
    var sortedEntries = _entries.OrderBy(entry => DateTime.Parse(entry._date)).ToList();
    string earliestDate = sortedEntries.First()._date;
    string latestDate = sortedEntries.Last()._date;

    // Display statistics
    Console.WriteLine("Journal Statistics:");
    Console.WriteLine($"- Total Entries: {totalEntries}");
    Console.WriteLine($"- Most Common Mood: {mostCommonMood}");
    Console.WriteLine($"- Earliest Entry: {earliestDate}");
    Console.WriteLine($"- Latest Entry: {latestDate}");
}

}


