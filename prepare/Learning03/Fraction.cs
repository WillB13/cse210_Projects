using System;

public class Fraction
{
    private int _numer;
    private int _denom;

    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numer = wholeNumber;
        _denom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numer = top;
        SetDenom(bottom);
    }

    public void SetDenom(int bottom)
    {
        if (bottom != 0)
        {
            _denom = bottom;
        }
        else
        {
            _denom = 1;
        }
    }

    public void SetNumer(int top)
    {
        _numer = top;
    }

    public int GetNumer()
    {
        return _numer;
    }
    public int GetDenom()
    {
        return _denom;
    }

    public string GetFractionString()
    {
        string text = $"{_numer}/{_denom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_numer / (double)_denom;
    }
}