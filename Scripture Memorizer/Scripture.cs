using System;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    private string originalVerse;
    private string currentVerse;
    private List<string> words;
    private HashSet<int> replacedIndices;

    public Scripture(string verse)
    {
        originalVerse = verse;
        currentVerse = verse;
        words = new List<string>(verse.Split(' '));
        replacedIndices = new HashSet<int>();
    }

    public string GetVerse()
    {
        return currentVerse;
    }

    public void ReplaceRandomWord()
    {
        Random random = new Random();
        List<int> remainingIndices = Enumerable.Range(0, words.Count)
                                                .Where(i => !replacedIndices.Contains(i))
                                                .ToList();

        if (remainingIndices.Count == 0) return;

        int index = remainingIndices[random.Next(remainingIndices.Count)];
        string wordToReplace = words[index];
        words[index] = new string('-', wordToReplace.Length);
        replacedIndices.Add(index);

        currentVerse = string.Join(" ", words);
    }

    public bool AllWordsReplaced()
    {
        return replacedIndices.Count == words.Count;
    }
}
