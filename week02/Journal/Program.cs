//Program.cs:
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
        int newNumber = 0;
        Console.WriteLine("Hello World! This is the Journal Project.");
        //step1: what I want to do...
        Console.WriteLine("Please select one of the following choice:");
        Console.WriteLine("1. Write a new journal entry.");
        Console.WriteLine("2. Display the journal.");
        Console.WriteLine("3. Load entries from a file");
        Console.WriteLine("4. Save entries to a file");
        Console.WriteLine("5. Quit");
        //step2: create classes to use: journal, entry, prompt.
        
        while (newNumber >= 1 && newNumber <=5 )
        {
            Console.Write("What would you like to do? (1-5): ");
            string userResponse = Console.ReadLine();
            newNumber = int.Parse(userResponse);
            //return newNumber;
            if (newNumber == 1)
            {}
            else if (newNumber == 2)
            {}
            else if (newNumber == 3)
            {}
            else if (newNumber == 4)
            {}
            else if (newNumber == 5)
            {}
            else 
            {
                Console.Write("Enter a valite number: ");
            }
        }

    }
}



//note: part1 original video... https://video.byui.edu/media/t/1_vmeovorz 