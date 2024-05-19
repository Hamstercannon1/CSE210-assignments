class Journal 
{
    List<Entry> _entryList = new List<Entry>();
    public void DisplayJournal()
    {
        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();
        }
    }

    public void AddEntry(Entry addedEntry)
    {
        _entryList.Add(addedEntry);
    }

    
}