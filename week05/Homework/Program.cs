using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
    
        Assignment assignment = new Assignment("Josh Peck", "Analisys and Filosofy: Letter to Gnomo");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("\n");

        MathAssignment mathAssignment = new MathAssignment("Scarlet John", "Fractions", "Section 5.1", "1-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("\n");
    }
}