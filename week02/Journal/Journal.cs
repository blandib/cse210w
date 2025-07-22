

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void ReplaceEntries(List<Entry> newEntries)
    {
        _entries = newEntries;
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

   public void SaveToFile(string filename)
{
    try
    {
        // Append ".txt" if it's missing
        if (!filename.EndsWith("myfile.txt"))
        {
            filename += "myfile.txt";
        }

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.GetDate());
                writer.WriteLine(entry.GetPrompt());
                writer.WriteLine(entry.GetText());
                writer.WriteLine("-----");
            }
        }

        Console.WriteLine("Journal saved successfully to " + filename);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error saving journal: " + ex.Message);
    }
}
public void LoadFromFile(string filename)
{
   
    if (!filename.EndsWith("myfile.txt"))
    {
        filename += "myfile.txt";
    }

    if (File.Exists(filename))
    {
        Load loader = new Load();
        List<Entry> loadedEntries = loader.LoadJournal(filename);
        ReplaceEntries(loadedEntries);
        Console.WriteLine("Journal loaded successfully from " + filename);
    }
    else
    {
        Console.WriteLine("File not found: " + filename);
    }
}

}

    