using System;
using System.ComponentModel.DataAnnotations;
class Entry
{   
    
    public string _text;
    public string _date;
    public string _prompt="";

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nText: {_text}");
    }

    public void setDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
    }
}
