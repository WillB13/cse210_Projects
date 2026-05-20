using System;
using System.Collections.Generic;

class Journal
{
    private List<JournalEntry> _journalEntries = new List<JournalEntry>();
    private List<JournalEntry> _savedBackup = new List<JournalEntry>();
    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        if (_journalEntries.Count == 0)
        {
            Console.WriteLine("There is nothing in the journal yet.");
            return;
        }

        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void SaveToMemory()
    {
        _savedBackup = new List<JournalEntry>(_journalEntries);
        Console.WriteLine("Journal saved to memory!");
    }
    public void LoadFromMemory()
    {
        if (_savedBackup.Count > 0)
        {
            _journalEntries = new List<JournalEntry>(_savedBackup);
            Console.WriteLine("Journal loaded from memory!");
        }
        else
        {
            Console.WriteLine("Nothing has been saved yet.");
        }
    }
}