public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
        : base(name, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal|{_name}|{_points}";
    }
}