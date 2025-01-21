bool exit = false;

while (!exit)
{
    Console.Clear();

    void StartGame()
    {   
        void Attempt()
        {
            Console.Write("Guess the secret number (1-100): ");
            int userGuess = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You guessed {userGuess}!");
            Console.ReadLine();

            Console.Clear();
            int secretNumber = 42;

            string success = "You've guessed correctly!";
            string failure = "Wrong.";

            string message = userGuess == secretNumber ? success : failure;

            Console.WriteLine(message);
        }

        int tries = 0;
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Attempt: {++tries}");
            Attempt();
        }






        // User chooses whether or not to play again.
        void PlayAgain()
        {
            Console.WriteLine("\nPlay again (y/n)?");
            string choice = Console.ReadLine().Trim().ToLower();
            switch (choice)
            {
                case "y":
                    Console.Clear();
                    StartGame();
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("See you next time!");
                    exit = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
        PlayAgain();
    }


    StartGame();
}