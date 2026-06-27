using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;

            if (_timesCompleted == _target)
            {
                return _points + _bonus;
            }

            return _points;
        }

        return 0;
    }

    public override string GetDetails()
    {
        string check = (_timesCompleted >= _target) ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description}) -- {_timesCompleted}/{_target}";
    }

    public override string SaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_timesCompleted}|{_target}|{_bonus}";
    }
}