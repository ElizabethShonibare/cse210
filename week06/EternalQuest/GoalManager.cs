using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];
            Console.WriteLine($"{i + 1}. {g.GetStatus()} {g.GetName()}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
            return;

        _score += _goals[index].RecordEvent();
        Console.WriteLine($"Score: {_score}");
    }

    public void ShowScore()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
        // Exceeding requirements
        ShowBadge();
    }

    // SAVE
    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    // LOAD
    public void Load(string filename)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];

            if (type == "Simple")
            {
                SimpleGoal g = new SimpleGoal(parts[1], int.Parse(parts[2]));
                _goals.Add(g);
            }
            else if (type == "Eternal")
            {
                EternalGoal g = new EternalGoal(parts[1], int.Parse(parts[2]));
                _goals.Add(g);
            }
            else if (type == "Checklist")
            {
                ChecklistGoal g = new ChecklistGoal(
                    parts[1],
                    int.Parse(parts[2]),
                    int.Parse(parts[5]),
                    int.Parse(parts[3])
                );
                _goals.Add(g);
            }
        }
    }


    // Exceeding requirements 
    public void ShowBadge()
    {
        string badge;

        if (_score >= 5000)
        {
            badge = "🥇 Gold";
        }
        else if (_score >= 2500)
        {
            badge = "🥈 Silver";
        }
        else if (_score >= 1000)
        {
            badge = "🥉 Bronze";
        }
        else
        {
            badge = "Beginner";
        }

        Console.WriteLine($"Badge: {badge}");
    }

    public void ShowLevel()
    {
        int level = (_score / 1000) + 1;
        Console.WriteLine($"Level: {level}");
    }
}