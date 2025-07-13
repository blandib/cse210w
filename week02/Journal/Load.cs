using System;
using System.Collections.Generic;
using System.IO;
public class Load
{
    public List<Entry> LoadJournal(string filename)
    {
        List<Entry> entries = new List<Entry>();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4) 
        {
            string date = lines[i];
            string prompt = lines[i + 1];
            string text = lines[i + 2];
            entries.Add(new Entry(date, prompt, text));
        }

        return entries;
    }
}