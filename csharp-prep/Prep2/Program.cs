using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string percentGrade = Console.ReadLine();
        int number = int.Parse(percentGrade);
        
        string lgradeLetter = "";

        if (percent >= 90)
        {
            gradeLetter = "A";
        }
        else if (percent >= 80)
        {
            gradeLetter = "B";
        }
        else if (percent >= 70)
        {
            gradeLetter = "C";
        }
        else if (percent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
    
}