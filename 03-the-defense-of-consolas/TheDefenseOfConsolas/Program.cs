// Written by Nicolas
// 1/28

using System;

public class DeploymentCalculator
{
    // Class variables
    private int targetRow = -1;
    private int targetCol = -1;

    // Properties
    public int TargetRow
    {
        get {return this.targetRow;}
        set {this.targetRow = value;}
    }

    public int TargetCol
    {
        get {return this.targetCol;}
        set {this.targetCol = value;}
    }

    // Full constructor
    public DeploymentCalculator(int _targetRow, int _targetCol)
    {
        targetRow = _targetRow;
        targetCol = _targetCol;
    }

    // Empty constructor
    public DeploymentCalculator() : this(-1, -1) {}

    // Methods
    public (int, int) Left()
    {
        return (targetRow, targetCol - 1);
    }

    public (int, int) Up()
    {
        return (targetRow - 1, targetCol);
    }

    public (int, int) Right()
    {
        return (targetRow, targetCol + 1);
    }

    public (int, int) Down()
    {
        return (targetRow + 1, targetCol);
    }

    public override string ToString()
    {
        return $"Deploy to:\n({Left().Item1}, {Left().Item2})\n({Up().Item1}, {Up().Item2})\n({Right().Item1}, {Right().Item2})\n({Down().Item1}, {Down().Item2})";
    }

    public static void Main()
    {
        Console.Write("Target Row? ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Target Column? ");
        int col = Convert.ToInt32(Console.ReadLine());

        DeploymentCalculator deployment = new DeploymentCalculator(row, col);
        Console.WriteLine(deployment);
    }
}
