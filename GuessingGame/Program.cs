namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 0;
            int playerGuess;

            Random rng = new Random();
            string choice;

            Console.WriteLine("Choos your difficulty, easy / medium / hard");
            choice = Console.ReadLine();

            if (choice == "easy")
            {
                secretNumber = rng.Next(1, 10);
            }

            if (choice == "medium")
            {
                secretNumber = rng.Next(1, 100);
            }

            if (choice == "hard")
            {
                secretNumber = rng.Next(1, 1000);  
            }

            do
            {
                playerGuess = int.Parse(Console.ReadLine());

                if (playerGuess > secretNumber)
                {
                    Console.WriteLine("Your Guess is too high");
                }
                if (playerGuess < secretNumber)
                {
                    Console.WriteLine("Your guess is too low");
                }
                if (playerGuess == secretNumber)
                {
                    Console.WriteLine("You guessed the secret number");
                }
            } while (secretNumber != playerGuess);
            Console.ReadLine();
        }
    }
}