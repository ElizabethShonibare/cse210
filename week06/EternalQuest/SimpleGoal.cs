public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points)
        : base(name, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
            return 0;

        _isComplete = true;
        return _points;
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple|{_name}|{_points}|{_isComplete}";
    }
}