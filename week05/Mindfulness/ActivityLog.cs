// Exceeding requirement

using System;
using System.Collections.Generic;
using System.IO;

public static class ActivityLog
{
    private static string _fileName = "activitylog.txt";

    private static Dictionary<string, int> _counts =
        new Dictionary<string, int>()
        {
            {"Breathing Activity", 0},
            {"Reflection Activity", 0},
            {"Listing Activity", 0}
        };

    public static void Load()
    {
        if (!File.Exists(_fileName))
            return;

        string[] lines = File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('=');

            if (parts.Length == 2)
            {
                string activity = parts[0];

                if (int.TryParse(parts[1], out int count))
                {
                    _counts[activity] = count;
                }
            }
        }
    }

    public static void Save()
    {
        List<string> lines = new List<string>();

        foreach (var item in _counts)
        {
            lines.Add($"{item.Key}={item.Value}");
        }

        File.WriteAllLines(_fileName, lines);
    }

    public static void RecordActivity(string activityName)
    {
        if (_counts.ContainsKey(activityName))
        {
            _counts[activityName]++;
        }

        Save();
    }

    public static void DisplayStatistics()
    {
        Console.Clear();

        Console.WriteLine("Activity Statistics");
        Console.WriteLine("-------------------");

        int total = 0;

        foreach (var item in _counts)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");

            total += item.Value;
        }

        Console.WriteLine();
        Console.WriteLine($"Total Activities Completed: {total}");

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}

