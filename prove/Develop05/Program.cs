using System;
using System.Collections.Generic;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    public static void Main(string[] args)
    {
        LoadGoals();

        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    SaveGoals();
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. Show goals");
        Console.WriteLine("4. Save and quit");
        Console.WriteLine($"Current score: {score}");
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1. Simple, 2. Eternal, 3. Checklist):");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter required count: ");
                int requiredCount = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, requiredCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            score += goals[goalIndex].RecordEvent();
            Console.WriteLine($"Event recorded. New score: {score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private static void ShowGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    private static void SaveGoals()
    {
        LoadSave.Save(goals, score);
    }

    private static void LoadGoals()
    {
        var result = LoadSave.Load();
        goals = result.Item1;
        score = result.Item2;
    }
}
