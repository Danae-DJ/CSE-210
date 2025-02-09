using System;
using System.Threading;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing as many as you can.")
    {}

    public void RunListening()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("\n");
        Console.WriteLine("You have a few seconds to think before you start again...");
        ShowSpinner(6);

        Console.WriteLine("\n");
        Console.WriteLine("Estart listing your ideas. Press enter each one: ");


        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(">");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response));
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"You listen {responses.Count} items.");
        DisplayEndingMessage();
    }
}











//note:https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-9.0