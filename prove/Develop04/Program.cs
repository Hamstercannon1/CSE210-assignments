using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. List");
            Console.WriteLine("2. Breathe");
            Console.WriteLine("3. Reflect");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new List();
                    break;
                case "2":
                    activity = new Breathe();
                    break;
                case "3":
                    activity = new Reflect();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.Start();
        }
    }
}
