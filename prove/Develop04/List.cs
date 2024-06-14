using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class List : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public List() : base("List", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void ExecuteActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        PauseWithCountdown(5);

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items:");

        using (CancellationTokenSource cts = new CancellationTokenSource())
        {
            var inputTask = Task.Run(() =>
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    if (Console.KeyAvailable)
                    {
                        string item = Console.ReadLine();
                        if (!string.IsNullOrEmpty(item))
                        {
                            items.Add(item);
                        }
                    }
                }
            }, cts.Token);

            Thread.Sleep(Duration * 1000);
            cts.Cancel();

            try
            {
                inputTask.Wait(cts.Token);
            }
            catch (OperationCanceledException) { }
        }

        Console.WriteLine($"You have listed {items.Count} items.");
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
