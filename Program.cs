bool exit = false;

while (!exit)
{
    Console.Clear();

    void StartGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        void Attempt()
        {
            Console.Write("Guess the secret number (1-100): ");
            int userGuess = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You guessed {userGuess}!");
            Console.ReadLine();

            Console.Clear();



            string success = "You've guessed correctly!";
            string failure = "Wrong.";

            string message = userGuess == secretNumber ? success : failure;

            Console.WriteLine(message);
            Console.WriteLine($"The secret number was {secretNumber}");

            if (message == success)
            {
                PlayAgain();
            }
        }

        int tries = 5;
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Attempts left: {--tries}");
            Attempt();
            if (exit) break;
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
                    PlayAgain();
                    break;
            }

        }
        if (!exit) PlayAgain();
    }


    StartGame();
}