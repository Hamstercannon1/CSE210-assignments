using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your grade percentage: ");
        string percent = Console.ReadLine();
        int numberGradeTest = int.Parse(percent);

        string letter="";

        if (numberGradeTest >= 90)
        {
            letter ="A";
            
            
        }
        else if (numberGradeTest >= 80)
        {
            letter="B";
        }

        else if (numberGradeTest >= 70)
        {
            letter = "C";
        }
        else if (numberGradeTest >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter} ");

        if (numberGradeTest>=70)
        {
            Console.WriteLine("Congratulations! You passed the course! ");
        }
        else
        {
            Console.WriteLine("Better luck next time. ");
        }
    }
}