using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "Alice", 600);
        video1.AddComment(new Comment("John", "Great Video!"));
        video1.AddComment(new Comment("Sarah", "Very informative"));
        video1.AddComment(new Comment("Mike","Loved the explanation"));
        videos.Add(video1);
    
        Video video2 = new Video("OOP in C#", "Bob", 900);
        video2.AddComment(new Comment("Emma", "This was helpful."));
        video2.AddComment(new Comment("James", "Could you explain polymorphism?"));
        video2.AddComment(new Comment("Charly", "What? :("));
        videos.Add(video2);
    
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}