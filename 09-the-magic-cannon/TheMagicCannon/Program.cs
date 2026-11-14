// Written by Nicolas
// 3/2/2025

public class MagicCannon
{
    // Variables
    private int turnNumber = -1;

    // Gets and Sets
    public int TurnNumber
    {
        get { return this.turnNumber; }
        set { this.turnNumber = value; }
    }

    // Full Constructor
    public MagicCannon(int _turnNumber)
    {
        turnNumber = _turnNumber;
    }

    // Empty Constructor
    public MagicCannon() : this(-1) {}

    // Methods
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            MagicCannon cannon = new MagicCannon(i);
            cannon.DetermineBlast();
            Console.WriteLine(cannon.ToString());
        }
        Console.ResetColor(); // Reset color at the end
    }

    public void DetermineBlast()
    {
        string blastType = GetBlastType();

        if (blastType == "Fire & Electric") Console.ForegroundColor = ConsoleColor.Blue;
        else if (blastType == "Fire") Console.ForegroundColor = ConsoleColor.Red;
        else if (blastType == "Electric") Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ResetColor();
    }

    public string GetBlastType()
    {
        if (turnNumber % 3 == 0 && turnNumber % 5 == 0) return "Fire & Electric";
        if (turnNumber % 3 == 0) return "Fire";
        if (turnNumber % 5 == 0) return "Electric";
        return "Normal";
    }

    // ToString() Method
    public override string ToString()
    {
        return $"{turnNumber}: {GetBlastType()}";
    }
}
