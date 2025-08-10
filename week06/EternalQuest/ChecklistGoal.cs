using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private int _completed;
   

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
            return _points + _bonus;
        return _points;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} — Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_shortName} ({_description}) — {_amountCompleted}/{_target}";
    }
   public ChecklistGoal(string name, string description, int points, int completed, int target, int bonus)
    : base(name, description, points)
{
    _completed = completed;
    _target = target;
    _bonus = bonus;
}

}
