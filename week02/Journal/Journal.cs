using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._promptText}");
                Console.WriteLine($"Journal: {entry._entryText}\n");
            }
        }
    }
}