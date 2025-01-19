// step 3: Entry.cs: create entry of information
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string _mood;  // Extra
    public string _tags;  // Extra

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");  // Extra
        Console.WriteLine($"Tags: {_tags}");  // Extra
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("");
    }
}



