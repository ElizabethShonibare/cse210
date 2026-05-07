using System;

class Program
{
    static void Main()
    {
        string playAgain;

        do
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            while (guess != secretNumber)
            {
                Console.Write("Guess the number (1-100): ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Guess higher!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Guess lower!");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}