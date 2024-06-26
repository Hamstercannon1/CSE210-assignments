using System;

public class Program
{
    static void Main(string[] args)
    {
        string verseText = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string referenceText = "Proverbs 3:5-6";
        string _input;

        Scripture scripture = new Scripture(verseText);
        Reference reference = new Reference(referenceText);

        Console.WriteLine(reference.GetReference());
        Console.WriteLine(scripture.GetVerse());

        while (!scripture.AllWordsReplaced())
        {
            Console.WriteLine("Press Enter to replace a random word...");
            _input = Console.ReadLine();
            if (_input == "quit")
            {
                Console.WriteLine("Thank you! Have a wonderful day!");
                break;
            }
            scripture.ReplaceRandomWord();
            Console.WriteLine(scripture.GetVerse());
        }

        if (scripture.AllWordsReplaced())
        {
            Console.WriteLine("All words have been replaced! Please play again!");
        }
    }
}
