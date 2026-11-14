class ManticoreBattle
{
    private int manticoreHealth = 10;
    private int cityHealth = 15;
    private int round = 1;
    private int manticoreDistance;

    public ManticoreBattle()
    {
        manticoreDistance = GetManticoreDistance();
        Console.Clear();
    }

    public void StartGame()
    {
        while (manticoreHealth > 0 && cityHealth > 0)
        {
            DisplayStatus();
            int damage = CalculateDamage();
            Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

            int playerGuess = GetPlayerGuess();

            if (playerGuess < manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round FELL SHORT of the target.");
            }
            else if (playerGuess > manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round OVERSHOT the target.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That round was a DIRECT HIT!");
                manticoreHealth -= damage;
            }
            Console.ResetColor();

            if (manticoreHealth > 0)
            {
                cityHealth--;
            }
            round++;
        }

        DisplayOutcome();
    }

    private int GetManticoreDistance()
    {
        int distance;
        do
        {
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? (0-100): ");
        } while (!int.TryParse(Console.ReadLine(), out distance) || distance < 0 || distance > 100);
        return distance;
    }

    private void DisplayStatus()
    {
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"STATUS: Round: {round} | City: {cityHealth}/15 | Manticore: {manticoreHealth}/10");
        Console.ResetColor();
    }

    private int CalculateDamage()
    {
        if (round % 3 == 0 && round % 5 == 0) return 10;
        if (round % 3 == 0 || round % 5 == 0) return 3;
        return 1;
    }

    private int GetPlayerGuess()
    {
        int guess;
        do
        {
            Console.Write("Enter desired cannon range: ");
        } while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 100);
        return guess;
    }

    private void DisplayOutcome()
    {
        Console.WriteLine("-----------------------------------------------------------");
        if (manticoreHealth <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The city has been destroyed! The Manticore reigns supreme!");
        }
        Console.ResetColor();
    }
}
