using System;
using System.Collections.Generic;
using System.IO;

public class Save
{
    public void SaveJournal(string filename, List<Entry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {

            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.GetDate());
                writer.WriteLine(entry.GetPrompt());
                writer.WriteLine(entry.GetText());
                writer.WriteLine("-----");
               
            }
            
        }
          
    }
    
}
