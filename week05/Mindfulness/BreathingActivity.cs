//BreathingActivity
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
            /*Extra: especial animation 
            --(NOTA: I'm not sure if this works, 
            I stopped playing it when something appeared 
            in the terminal)  */
            AnimateBreathing("Breat in...", 6,true);

            AnimateBreathing("Now breath  out...", 6, false);

            /*option1 
            Console.WriteLine("\nBreath in...");
            ShowCoundDown(6);

            Console.WriteLine("\nNow breath out...");
            ShowCoundDown(6);*/

        }
        
        DisplayEndingMessage();
        RunActivity(); //extra
    }

        /*Extra: especial animation -- void */
        /*(NOTA: I'm not sure if this works, 
            I stopped playing it when something appeared 
            in the terminal)*/
        public void AnimateBreathing(string message, int countDownTime, bool isBreathingIn)
        {
            int maxWidth = 25;
            double stepFactor = isBreathingIn ? 0.5 : -0.2;

            for (int i = 0; i < countDownTime; i++)
            {
                int currentWidth = (int)(maxWidth * (i /(double)countDownTime));
                string text = new string(' ', currentWidth) + message;
                Console.Clear();
                Console.WriteLine(text);
                Thread.Sleep(500);
            }
        }
        



}


//https://stackoverflow.com/questions/40242279/simulate-loading-with-thread-sleep
//https://www.youtube.com/watch?v=A3UqpcQu4E0