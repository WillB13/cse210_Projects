using System;

class Menu
{
    private Journal _myJournal = new Journal();

    public void Start()
    {
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load journal from memory");
            Console.WriteLine("4. Save journal to memory");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                JournalEntry newEntry = new JournalEntry();
                newEntry.CreateJournalEntry();
                _myJournal.AddJournalEntry(newEntry);
            }
            else if (choice == "2")
            {
                _myJournal.DisplayJournal();
            }
            else if (choice == "3")
            {
                _myJournal.LoadFromMemory();
            }
            else if (choice == "4")
            {
                _myJournal.SaveToMemory();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option, please choose 1-5.");
            }
        }
    }
}