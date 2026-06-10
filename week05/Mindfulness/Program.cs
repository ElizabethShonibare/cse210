using System;

class Program
{
    static void Main()
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            // Exceeding requirements
            Console.WriteLine("4. View Statistics");
            Console.WriteLine("5. Quit");


            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                //Exceeding requirements 
                case "4":
                    ActivityLog.DisplayStatistics();
                    break;
            }
        }
    }
}