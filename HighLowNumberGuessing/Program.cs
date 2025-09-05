namespace HighLowNumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GUESS_LIMIT = 7;
            const int LOW_GUESS_LIMIT = 1;
            const int HIGH_GUESS_LIMIT = 100;

            Boolean win = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");

            // Game loops until the player does not want to play anymore
            Random rng = new Random();

            while (true)
            {

                // Generate Random Number from LOW_GUESS_LIMIT to HIGH_GUESS_LIMIT
                int secretNumber = rng.Next(LOW_GUESS_LIMIT, HIGH_GUESS_LIMIT);

                Console.WriteLine($"\nGuess a number between {LOW_GUESS_LIMIT} and {HIGH_GUESS_LIMIT}.");

                for (int i = 0; i < GUESS_LIMIT; i++)
                {
                    // Ask for the players guess
                    Console.WriteLine("\nGuess a number: ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    if (userNumber == secretNumber)
                    {
                        // Player guesses correct number
                        Console.WriteLine("You got it!! You Win!!");
                        win = true;
                        break;
                    }
                    if (Math.Abs(secretNumber - userNumber) <= 5 && userNumber != secretNumber)
                    {
                        Console.WriteLine("You are close!");
                    }

                    if (userNumber < secretNumber)
                    {
                        // Player guess is too low
                        Console.WriteLine($"Too low. You have {GUESS_LIMIT - i - 1} guesses left.");
                        continue;

                    }
                    if (userNumber > secretNumber)
                    {
                        // Player guess is too high
                        Console.WriteLine($"Too high. You have {GUESS_LIMIT - i - 1} guesses left.");
                        continue;

                    }

                }

                // Let player know they did not guess the right number in the limited number of tries
                if (!win)
                {
                    Console.WriteLine($"\nYou lose. The correct number is {secretNumber}.\n");
                }

                // Ask the player if they want to play again
                Console.WriteLine("Want to play again? (Y/N): ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }
        }
    }
}
