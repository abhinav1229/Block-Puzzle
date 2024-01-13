using System;

class Program
{
    static void Main()
    {
        GuessingGame player = new();

        while (!player.IsGuessedCorrectly())
        {
            player.PlayGame();
        }
    }
}
