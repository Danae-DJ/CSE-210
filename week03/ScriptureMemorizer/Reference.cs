public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //Extra: reference to load new scriptures
    public static Reference Parse(string referenceText)
    {
        string[] parts = referenceText.Split(" ");
        string book = parts[0];
        string[] chapterAndVerses = parts[1].Split(":");
        int chapter = int.Parse(chapterAndVerses[0]);
        
        if (chapterAndVerses[1].Contains("-"))
        {
            string[] verses = chapterAndVerses[1].Split("-");
            return new Reference(book, chapter, int.Parse(verses[0]), int.Parse(verses[1]));
        }
        else
        {
            return new Reference(book, chapter, int.Parse(chapterAndVerses[1]));
        }
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }


}