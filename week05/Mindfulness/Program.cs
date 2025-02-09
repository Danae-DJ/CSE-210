//Program.cs
using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("We have three activities for you, they going to help you to get up your spirit, reflexing and relaxing your mind: ");
            

        while(true)
        {   
            
            //create a menu
            Console.WriteLine("********************");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("********************");
            Console.WriteLine("Please, choose an option (1-4): ");

            //create options
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    //1
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathing();
                    break;

                case "2":
                    //2
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunReflection();
                    break;

                case "3":
                    //3
                    ListingActivity listing = new ListingActivity();
                    listing.RunListening();
                    break;

                case "4":
                    Console.WriteLine("Thanks For using the Mindfulness Project. See you another day.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Press any Key to try again...");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("\nRemember that you can continue the exercises as much as you want, as well as finish whenever you like.");
            
            //return menu
        }
    }

}






/*
        //create base
        Activity testActivity = new Activity("Test Activity", "This is a test");
        testActivity.DisplayStartMessage();
        testActivity.ShowCoundDown(5);
        testActivity.DisplayEndingMessage();
*/