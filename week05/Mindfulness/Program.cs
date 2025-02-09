using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("We have three activities for you, they going to help you to get up your spirit, reflexing and relaxing your mind: ");
        
        //create a menu
        Console.WriteLine("********************");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("3. Exit");
        Console.WriteLine("********************");
        Console.WriteLine("Please, choose an option (1-4): ");

        string choice = Console.ReadLine();

        //create base
        Activity testActivity = new Activity("Test Activity", "This is a test");
        testActivity.DisplayStartMessage();
        testActivity.ShowCoundDown(5);
        testActivity.DisplayEndingMessage();


        
        //create options
        //1
        BreathingActivity breathing = new BreathingActivity();
        breathing.RunBreathing();

        //2
        ReflectionActivity reflection = new ReflectionActivity();
        reflection.RunReflection();

        //3
        ListingActivity listing = new ListingActivity();
        listing.RunListening();
        
        
        //pausing activity
        //continue other round or other activite
        //extending
    
    
    
    
    }
}