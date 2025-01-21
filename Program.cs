bool exit = false;

while (!exit)
{
    Console.Clear();

    void StartGame()
    {
        Console.WriteLine("Choose your difficulty:\n1. Easy\n2. Medium\n3. Hard\n4. Cheater");
        int difficultyChoice = int.Parse(Console.ReadLine());
        int lives = 0;
        switch (difficultyChoice)
        {
            case 1:
                lives = 8;
                break;
            case 2:
                lives = 6;
                break;
            case 3:
                lives = 4;
                break;
            case 4:
                lives = int.MaxValue;
                break;
        }

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

            if (userGuess > secretNumber)
            {
                Console.WriteLine("The secret is a lower number");
            }
            if (userGuess < secretNumber)
            {
                Console.WriteLine("The secret is a higher number");
            }

            string message = userGuess == secretNumber ? success : failure;

            Console.WriteLine(message);
            // Console.WriteLine($"The secret number was {secretNumber}");

            if (message == success)
            {
                PlayAgain();
            }
        }

        int tries = lives;
        for (int i = 0; i < tries; i++)
        {
            Console.WriteLine((lives > 8) ? "Infinite attempts" : $"Attempts left: {--lives + 1}");
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