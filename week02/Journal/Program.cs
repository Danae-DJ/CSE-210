//step6: assemble the Program.cs:
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PrompGenerator prompGenerator = new PrompGenerator();
        bool running = true;

        Console.WriteLine("Hello World! This is the Journal Project.");

        while (running)
        {
            /*Entry anEntry = new Entry();
            anEntry.Display();
            int newNumber = 0;*/
            
            //step1: what I want to do...
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write a new journal entry.");
            Console.WriteLine("2. Display the journal.");
            Console.WriteLine("3. Load entries from a file");
            Console.WriteLine("4. Save entries to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (1-5): ");
            //step2: create classes to use: journal, entry, prompt.

        
            string userResponse = Console.ReadLine();
            //return newNumber;
            switch (userResponse)
            {
                //Write
                case "1":
                    string prompt = prompGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompt,
                        _entryText = response
                    };
                    theJournal.AddEntry(newEntry);
                    break;

                //Display
                case "2":
                    theJournal.Display();
                    break;

                //Load
                case "3":
                    Console.Write("Enter the filename to load from: ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;

                //Save
                case "4":
                    Console.Write("Enter the filename to save to: ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;

                //Quit
                case "5":
                    running = false;
                    break;

                //Any option
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
        }

    }
}



//note: part1 original video... https://video.byui.edu/media/t/1_vmeovorz 