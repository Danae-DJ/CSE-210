using System;
using System.Threading;
class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Let's start with: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGo, get ready");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Great Job! You have complete the activity.");
        Console.WriteLine($"You spent {_duration} seconds on {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b\b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b\b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b\b");
        }
    }

    public void ShowCoundDown( int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("i");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDusration()
    {
        return _duration;
    }
}

//tutorial thread: https://www.codeproject.com/Tips/5305519/How-to-Action-a-Spinner-in-a-Console-Application
//https://stackoverflow.com/questions/5866190/thread-sleep-c-net