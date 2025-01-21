bool exit = false;

while (!exit)
{
    Console.Clear();

    void StartGame()
    {
        Console.Write("Guess the secret number (1-100): ");
        int userGuess = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"You guessed {userGuess}!");
        Console.ReadLine();

        Console.Clear();
        int secretNumber = 42;

        string success = "You've guessed correctly!";
        string failure = "You've guess wrong.";

        string message = userGuess == secretNumber ? success : failure;

        Console.WriteLine(message);
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


    StartGame();
}