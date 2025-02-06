using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("C#: Questions and Dudes", "Beatriz", 730);
        video1.AddComment(new Comment("Thom", "Good Video!"));
        video1.AddComment(new Comment("Jessica", "I have a dude ¡?"));
        video1.AddComment(new Comment("Mike","Loved the explanation"));
        video1.AddComment(new Comment("Joe","What mean dooble?"));
        videos.Add(video1);
    
        Video video2 = new Video("How to creata a file in C#", "Jeremy", 1200);
        video2.AddComment(new Comment("Jenny", "This was helpful."));
        video2.AddComment(new Comment("Emma", "Could you explain... Why I need to use the csm terminal?"));
        video2.AddComment(new Comment("Charly", "What? :("));
        video2.AddComment(new Comment("Frank", " I want more videos like this!!! :)"));
        videos.Add(video2);
    
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}