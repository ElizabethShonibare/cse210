public class ChecklistGoal : Goal
{
    private int _target;
    private int _progress;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus)
        : base(name, points)
    {
        _target = target;
        _bonus = bonus;
        _progress = 0;
    }

    public override int RecordEvent()
    {
        _progress++;

        if (_progress == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetStatus()
    {
        return $"[{_progress}/{_target}]";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_name}|{_points}|{_bonus}|{_progress}|{_target}";
    }
}