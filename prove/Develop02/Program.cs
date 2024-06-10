using System;

class Program
{
    // static Entry WriteNewEntry()
    // {
    //     // Course course1 = new Course();
    //     // Console.WriteLine("Are we having fun yet? ");
    //     // course1._className = "Prog. w/Classes";
    //     // course1._color = "blue";
    //     // course1._courseCode = "CSE 201";
    //     // course1._numberOfCredits = 2;
    //     // course1.Display();

    //     Prompt prompter = new Prompt();
    //     string newPrompt = prompter.GeneratePrompt();
    //     WriteLine(newPrompt);
    //     Write('Your entry: ');
    //     string response = ReadLine();
    //     DateTime rightNow = DateTime.Now;
    //     string rightNowText = $"{rightNow.ToShortDateString()} {rightNow.ToShortTimeString()}";

    //     Entry newEntry = new Entry();
    //     newEntry
    // }

    static void Main(string[] args)
    {
        Boolean running = true;
        while(running)
        {
            string _input;
            Console.WriteLine("1. Write an entry\n2. Load a journal \n3. Save journal \n4. Display all entries \n5. Close program");
            _input=Console.ReadLine();
            Journal journal = new Journal();
            if(_input == "1")
            {
                Entry newEntry = new Entry();
                Prompt newPrompt = new Prompt();
                newEntry.setDate();
                newEntry._prompt=newPrompt.MakePrompt();
                Console.WriteLine($"Prompt: {newEntry._prompt} (Type your response and press enter when finished)");
                newEntry._text = Console.ReadLine();
                journal.AddEntry(newEntry);
                
            }
            else if (_input == "4")
            {
                journal.DisplayJournal();
            }

            else if (_input == "5")
            {
                running=false;
                Console.WriteLine("Goodbye ");
            }
        } 
    }
}