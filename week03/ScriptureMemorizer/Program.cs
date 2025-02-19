using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scriptures.txt"; // File to store scriptures
        EnsureFileExists(filePath); // Ensure file exists

        while (true)
        {   // Extra: Ensure file exists
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer!"); 
            Console.WriteLine("1. Memorize a random scripture"); 
            Console.WriteLine("2. Add a new scripture"); //
            Console.WriteLine("3. View list of scriptures"); //
            Console.WriteLine("4. Select a scripture to memorize"); //
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MemorizeRandomScripture(filePath);
                    break;
                case "2":
                    AddNewScripture(filePath);
                    break;
                case "3":
                    ViewScriptures(filePath);
                    break;
                case "4":
                    SelectScripture(filePath);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void EnsureFileExists(string filePath)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }

    static void MemorizeRandomScripture(string filePath)
    {
        List<Scripture> scriptures = ScriptureLoader.LoadFromFile(filePath);

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available. Please add some scriptures first.");
            Console.ReadLine();
            return;
        }

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
        MemorizeScripture(selectedScripture);
    }

    static void AddNewScripture(string filePath)
    {
        Console.Clear();
        Console.WriteLine("Add a New Scripture");
        Console.Write("Enter the reference (e.g., John 3:16): ");
        string reference = Console.ReadLine();

        Console.Write("Enter the scripture text: ");
        string text = Console.ReadLine();

        File.AppendAllText(filePath, $"{reference} - {text}{Environment.NewLine}");

        Console.WriteLine("Scripture added successfully. Press Enter to continue...");
        Console.ReadLine();
    }

    static void ViewScriptures(string filePath)
    {
        Console.Clear();
        Console.WriteLine("List of Scriptures:");

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0)
        {
            Console.WriteLine("No scriptures found.");
        }
        else
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void SelectScripture(string filePath)
    {
        Console.Clear();
        Console.WriteLine("Select a Scripture to Memorize:");

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0)
        {
            Console.WriteLine("No scriptures available. Please add some scriptures first.");
            Console.ReadLine();
            return;
        }

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {lines[i]}");
        }

        Console.Write("Enter the number of the scripture you want to memorize: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= lines.Length)
        {
            string[] parts = lines[choice - 1].Split(" - ");
            if (parts.Length == 2)
            {
                Reference reference = Reference.Parse(parts[0]);
                Scripture selectedScripture = new Scripture(reference, parts[1]);
                MemorizeScripture(selectedScripture);
            }
        }
        else
        {
            Console.WriteLine("Invalid selection. Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void MemorizeScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Starting Scripture Memorization!");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("All words are hidden. Great job!");
        Console.WriteLine("Press Enter to return to the main menu...");
        Console.ReadLine();
    }
}
