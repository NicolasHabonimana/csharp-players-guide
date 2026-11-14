// Written by Nicolas
// 3/2/2025

public class ReplicatorOfDto
{
    // Variables
    private int[] originalArray = new int[5];
    private int[] copiedArray = new int[5];

    // Full Constructor
    public ReplicatorOfDto(int[] inputArray)
    {
        for (int i = 0; i < 5; i++)
        {
            originalArray[i] = inputArray[i];
            copiedArray[i] = inputArray[i]; // Manual copy
        }
    }

    // Empty Constructor
    public ReplicatorOfDto() {}

    // Methods
    public static void Main()
    {
        int[] userNumbers = new int[5];

        // Get user input
        Console.WriteLine("Enter 5 numbers to store in the array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            userNumbers[i] = GetValidNumber();
        }

        // Create instance of ReplicatorOfDto
        ReplicatorOfDto replicator = new ReplicatorOfDto(userNumbers);

        // Display both arrays
        Console.WriteLine("\nOriginal Array:");
        replicator.DisplayArray(replicator.originalArray);

        Console.WriteLine("\nCopied Array:");
        replicator.DisplayArray(replicator.copiedArray);
    }

    public static int GetValidNumber()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Enter a valid integer: ");
        }
        return number;
    }

    public void DisplayArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // ToString() Method
    public override string ToString()
    {
        return "The Replicator of D’To has successfully copied the array!";
    }
}
