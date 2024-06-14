public class Breathe : Activity
{
    public Breathe() : base("Breathe", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void ExecuteActivity()
    {
        int remainingTime = Duration;

        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3);
            remainingTime -= 3;

            if (remainingTime <= 0) break;

            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3);
            remainingTime -= 3;
        }
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

