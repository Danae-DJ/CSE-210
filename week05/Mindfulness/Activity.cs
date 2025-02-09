
//Activity.cs
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
        Console.WriteLine($"Wellcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long, would you like for your session? (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGreat Job!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {   //2 option
            string[] spinner = { "-", "\\", "|", "/" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(500);
            Console.Write("\b ");
        }
/*      one option...
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
        }*/
    }

    public void ShowCoundDown( int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("i");
            Thread.Sleep(1000);
            Console.Write("\b ");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    //Extra: counter times to use
    public static int ActivityCount = 0; //i need to start with a 0
    public void RunActivity()
    {
        ActivityCount++; 
        Console.WriteLine($"This has beed performed {ActivityCount} times");
    }


}

//tutorial thread: https://www.codeproject.com/Tips/5305519/How-to-Action-a-Spinner-in-a-Console-Application
//https://stackoverflow.com/questions/5866190/thread-sleep-c-net