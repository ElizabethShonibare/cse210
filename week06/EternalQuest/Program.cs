using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Add Simple Goal");
            Console.WriteLine("3. Add Eternal Goal");
            Console.WriteLine("4. Add Checklist Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Save");
            Console.WriteLine("8. Load");
            Console.WriteLine("9. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.ShowGoals();
            }
            else if (choice == "2")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                manager.AddGoal(new SimpleGoal(name, 100));
            }
            else if (choice == "3")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                manager.AddGoal(new EternalGoal(name, 50));
            }
            else if (choice == "4")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                manager.AddGoal(new ChecklistGoal(name, 50, 5, 500));
            }
            else if (choice == "5")
            {
                manager.ShowGoals();
                Console.Write("Which goal? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                manager.RecordEvent(index);
            }
            else if (choice == "6")
            {
                manager.ShowScore();
            }
            else if (choice == "7")
            {
                manager.Save("goals.txt");
            }
            else if (choice == "8")
            {
                manager.Load("goals.txt");
            }
            else if (choice == "9")
            {
                break;
            }
        }
    }
}