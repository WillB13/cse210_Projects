using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    public override string GetDetails()
    {
        string check = _isComplete ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description})";
    }

    public override string SaveString()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }
}