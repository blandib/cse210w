using System;
using System.Collections.Generic;
public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

    public string GetDate() => _date;
    public string GetPrompt() => _promptText;
    public string GetText() => _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine($"Response: {_entryText}\n");
    }
}