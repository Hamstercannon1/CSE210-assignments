public class ChecklistGoal : Goal
{
    public int RequiredCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints) : base(name, description, points)
    {
        RequiredCount = requiredCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            CurrentCount++;
            if (CurrentCount >= RequiredCount)
            {
                IsCompleted = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Name} (Checklist) - {Description} (+{Points} points each time, {CurrentCount}/{RequiredCount}, +{BonusPoints} bonus points)";
    }
}
