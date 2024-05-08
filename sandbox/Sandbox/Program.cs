using System;

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course();
        Console.WriteLine("Are we having fun yet? ");
        course1._className = "Prog. w/Classes";
        course1._color = "blue";
        course1._courseCode = "CSE 201";
        course1._numberOfCredits = 2;
        course1.Display();
    }
}