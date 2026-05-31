class ScriptureReference
{
    private string _BookName;

    private int _Chapter;

    private int _Verse;
    
    private int _EndVerse;

    public ScriptureReference(string bookName, int chapter, int verse)
    {
        _BookName = bookName;
        _Chapter = chapter;
        _Verse = verse;
        _EndVerse = verse;
    }

    public ScriptureReference(string bookName, int chapter, int verse, int endVerse)
    {
        _BookName = bookName;
        _Chapter = chapter;
        _Verse = verse;
        _EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_Verse == _EndVerse)
        {
            return $"{_BookName} {_Chapter}:{_Verse}";
        }

        return $"{_BookName} {_Chapter}:{_Verse}-{_EndVerse}";
    }
}
