using System;

class GuessingGame
{
    private readonly int tagetNumber = 0;
    bool hasGuessedCorrectly = false;
    private readonly int MIN_RANGE = 0;
    private readonly int MAX_RANGE = 100;

    public GuessingGame()
    {
        // Create an instance of the Random class
        Random random = new();

        // Generate a random number within the specified range
        this.tagetNumber = random.Next(MIN_RANGE, MAX_RANGE + 1);
    }

    private void ShowMessage(int guessedNumber)
    {
        if (tagetNumber == guessedNumber)
        {
            hasGuessedCorrectly = true;
            Console.WriteLine("Wao! Correct Guessed");
        }
        else if (guessedNumber > tagetNumber)
        {
            Console.WriteLine($"Target is lower than {guessedNumber}");
        }
        else
        {
            Console.WriteLine($"Target is higher than {guessedNumber}");
        }
    }

    public bool IsGuessedCorrectly()
    {
        return hasGuessedCorrectly;
    }

    public void PlayGame()
    {
        Console.Write("Please guess a number: ");

        string? userInput = Console.ReadLine();

        // Convert the string to a numeric type (e.g., int)
        if (int.TryParse(userInput, out int guessedNumber))
        {
            ShowMessage(guessedNumber);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
