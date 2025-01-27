//Extra: Load new scriptures

using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLoader
{
    public static List<Scripture> LoadFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(" - ");
                if (parts.Length == 2)
                {
                    Reference reference = Reference.Parse(parts[0]); // Parse the reference
                    Scripture scripture = new Scripture(reference, parts[1]); // Create Scripture object
                    scriptures.Add(scripture);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }

        return scriptures;
    }
}
