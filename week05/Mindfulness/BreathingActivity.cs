using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        :base ("Breathing Activity", "this activity will help you relax by guiding you through breathing in and out slowly. Peace and Calm down to your mind; only focus on you breathing.")
        {}

    public void RunBreathing()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Breath in...");
            ShowCoundDown(4);

            Console.WriteLine("\n");
            Console.WriteLine("Breath out...");
            ShowCoundDown(4);
        }

        DisplayEndingMessage();
    }
}