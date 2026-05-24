using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create scripture reference
            Reference reference = new Reference("Proverbs", 3, 5, 6);

            // Create scripture
            Scripture scripture = new Scripture(
                reference,
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            );

            // Exceeding Requirement:
            // I added a difficulty level feature(Easy, Medium, Hard) that changes how many words are hidden each round.This helps users memorize scriptures at different learning speeds and improves the memorization experience.
            Console.WriteLine("Choose Difficulty Level:");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            int wordsToHide = 3;

            switch (choice)
            {
                case "1":
                    wordsToHide = 1;
                    break;

                case "2":
                    wordsToHide = 3;
                    break;

                case "3":
                    wordsToHide = 5;
                    break;

                default:
                    wordsToHide = 3;
                    break;
            }

            // Main loop
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();

                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine();
                Console.Write("Press ENTER to continue or type 'quit' to exit: ");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(wordsToHide);
            }

            // Final display
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nAll words are hidden. Program ended.");
        }
    }
}