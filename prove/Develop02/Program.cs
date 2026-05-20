using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry myJournalEntry = new JournalEntry();
        myJournalEntry.CreateJournalEntry();
        myJournalEntry.DisplayJournalEntry();
        Console.WriteLine(myJournalEntry.CreateFileSystemString());
        Menu applicationMenu = new Menu();
        applicationMenu.Start();
        Journal myJournal = new Journal();
        myJournal.AddJournalEntry(myJournalEntry);

        myJournal.DisplayJournal();
    }
}