using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class LoadSave
{
    private const string FileName = "goals.txt";

    public static void Save(List<Goal> goals, int score)
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.IsCompleted},{(goal is ChecklistGoal checklist ? checklist.RequiredCount + "," + checklist.CurrentCount + "," + checklist.BonusPoints : "")}");
            }
        }
    }

    public static (List<Goal>, int) Load()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        if (File.Exists(FileName))
        {
            var lines = File.ReadAllLines(FileName).ToList();
            score = int.Parse(lines[0]);
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isCompleted = bool.Parse(parts[4]);

                Goal goal = type switch
                {
                    nameof(EternalGoal) => new EternalGoal(name, description, points),
                    nameof(SimpleGoal) => new SimpleGoal(name, description, points),
                    nameof(ChecklistGoal) => new ChecklistGoal(name, description, points, int.Parse(parts[5]), int.Parse(parts[7]))
                    {
                        CurrentCount = int.Parse(parts[6]),
                    },
                    _ => throw new InvalidOperationException("Unknown goal type")
                };

                goal.SetCompleted(isCompleted); // Use the new method to set IsCompleted
                goals.Add(goal);
            }
        }

        return (goals, score);
    }
}
