using System;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string[] _prompts = 
    {
        "How are you today?",
        "Who did you talk with?",
        "What happened today?",
        "Where did you go today?",
        "What did you do that was fun today?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Length);
        
        _prompt = _prompts[randomIndex];
        
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}