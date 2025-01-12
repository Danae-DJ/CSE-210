using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage (0-100)?");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        string letter  = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "c";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }


        //stretch challenge
        //sing
        if (letter != "F" && grade % 10 >= 7)
        {
            sign = "+";
        }

        else if (letter != "F" && grade % 10 < 3)
        {
            sign = "-";
        }


        //exceptions A & F
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }


        //Console.WriteLine($"Your letter grade is {letter}");
        Console.WriteLine($"Your letter grade is {letter}{sign}.");


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Try again next time.");
        }
    }
}

//video:https://video.byui.edu/media/t/1_78d651c6
//solution: https://github.com/byui-cse/cse210-ww-student-sample-solutions/blob/main/week01/Exercise2/Program.cs