using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        //create base
        Activity testActivity = new Activity("Test Activity", "This is a test");
        testActivity.DisplayStartMessage();
        testActivity.ShowCoundDown(5);
        testActivity.DisplayEndingMessage();


        //create a menu
        //1
        BreathingActivity breathing = new BreathingActivity();
        breathing.RunBreathing();

        //2
        ReflectionActivity reflection = new ReflectionActivity();
        reflection.RunReflection();
        //create option
        
        //crate activities
        //choice
        //pausing activity
        //end activity
        //continue other round or other activite
        //extending
    
    
    
    
    }
}