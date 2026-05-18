using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save document to a database or use a different library or format such as JSON for storage.
    public void SaveToFile(string file)
    {
        // Convert list to JSON
        string jsonString = JsonSerializer.Serialize(
            _entries,
            new JsonSerializerOptions { WriteIndented = true }
        );

        // Write JSON to file
        File.WriteAllText(file, jsonString);
    }

    // load my document to a database or use a different library or format such as JSON for storage.
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string jsonString = File.ReadAllText(file);

            // Replace current entries with loaded entries
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}