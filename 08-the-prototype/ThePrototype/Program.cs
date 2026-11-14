// Written by Nicolas
// 3/2/2025
public class AirshipTracker
{
    // Variables
    private int targetNumber = -1;

    // Gets and Sets
    public int TargetNumber
    {
        get { return this.targetNumber; }
        set { this.targetNumber = value; }
    }

    // Full Constructor
    public AirshipTracker(int _targetNumber)
    {
        targetNumber = _targetNumber;
    }

    // Empty Constructor
    public AirshipTracker() : this(-1) {}

    // Methods
    public static void Main()
    {
        Console.Write("User 1, enter a number between 0 and 100: ");
        int chosenNumber = GetValidNumber();

        AirshipTracker tracker = new AirshipTracker(chosenNumber);
        Console.Clear(); // Clear screen after pilot enters number

        Console.WriteLine("User 2, guess the number.");
        tracker.StartGuessing();
    }

    public static int GetValidNumber()
    {
        int number;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 100)
                return number;

            Console.Write("Invalid input. Enter a number between 0 and 100: ");
        }
    }

    public void StartGuessing()
    {
        int guess;
        while (true)
        {
            Console.Write("What is your next guess? ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess < targetNumber)
                    Console.WriteLine($"{guess} is too low.");
                else if (guess > targetNumber)
                    Console.WriteLine($"{guess} is too high.");
                else
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
