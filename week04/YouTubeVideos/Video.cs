using System;
class Video
{
    public string _Title;
    public string _Author;
    public int _Length;
    private List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;

    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_Title}, Author:{_Author}, Length:{_Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        foreach(var comment in Comments)
        {
            Console.WriteLine($"-{comment._Name}: {comment._Text}");
        }
    }
}