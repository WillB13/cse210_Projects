class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetDisplayText()
    {
        string tempWord = "";

        if (_hidden)
        {
            foreach (char c in _word)
            {
                tempWord += "_";
            }
        }
        else
        {
            tempWord = _word;
        }

        return tempWord;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}