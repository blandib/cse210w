using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
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

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName} ({_description})";
    }
    public SimpleGoal(string name, string description, int points, bool isComplete)
    : base(name, description, points)
{
    _isComplete = isComplete;
}

}
