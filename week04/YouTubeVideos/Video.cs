using System;
class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}, Author:{_author}, Length:{_length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        foreach(var comment in _comments)
        {
            Console.WriteLine($"-{comment.GetName()}: {comment.GetText()}");
        }
    }
}