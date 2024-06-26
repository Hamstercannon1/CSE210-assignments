public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{(IsCompleted ? "[X]" : "[ ]")} {Name} (Simple) - {Description} (+{Points} points)";
    }
}
