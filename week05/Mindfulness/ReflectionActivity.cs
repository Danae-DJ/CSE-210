
//ReflectionActivity.cs
using System;
using System.Threading;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Remember a time when you stood up someone else",
        "Think about when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Remember when you did something truly selfless"
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaning to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "why this activy was different from others?",
        "What was the most relevant part of this experience?",
        "What did you learn from this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
        :base("Reflection Activity", "This activity helps you reflect about events of your life when you have show strength and resilience.")
        {}

    public void RunReflection()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("\n" + selectedPrompt);
        ShowSpinner(4);

        while (DateTime.Now < endTime)
        {
            string question = questions[random.Next(questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(4);
        }
        
        DisplayEndingMessage();
        RunActivity();//extra
    }

}

//time: https://stackoverflow.com/questions/12998739/how-to-check-if-datetime-now-is-between-two-given-datetimes-for-time-part-only