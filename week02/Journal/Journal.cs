//step4: Journal.cs: operations to entrys
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
        
    }

    public void SavToFile()
    {

    }

    public void LoadFromFile()
    {

    }
}