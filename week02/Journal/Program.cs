// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Current working directory: " + Environment.CurrentDirectory);

        int choice = 0;

        while (choice != 5)
        {
            // Menu
            Console.WriteLine();
            Console.WriteLine("Journal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            // Write a new entry
            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry.Date = DateTime.Now.ToShortDateString();
                newEntry.PromptText = prompt;
                newEntry.EntryText = response;

                theJournal.AddEntry(newEntry);

                Console.WriteLine("Entry added.");
            }

            // Display journal
            else if (choice == 2)
            {
                Console.WriteLine();
                theJournal.DisplayAll();
            }

            // Save journal
            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully.");
            }

            // Load journal
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully.");
            }

            // Quit
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            // Invalid option
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}