//Written by nicolas
//2/02/2025

using System.Security.Cryptography.X509Certificates;

public class WatchTower
{
    //varriables
    private int y;
    private int x;
    //gets and sets
    public int Y
    {
        get{return this.y;}
        set{this.y = value;}
    }
    public int X
    {
        get{return this.x;}
        set{this.x = value;}
    }
    //full constructor
    public WatchTower(int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    //empty constructor
    public WatchTower() : this(-10000, -10000){}
    //methods
    public string whereIsTheEnemy(int x, int y)
    {
            if(x < 0 && y > 0) return "The enemies are NorthWest";
            if(x < 0 && y == 0) return "The enemies are West";
            if(x < 0 && y < 0) return "The enemies are SouthhWest";
            if(x == 0 && y > 0) return "The enemies are North";
            if(x == 0 && y == 0) return "We are attacked!!!";
            if(x == 0 && y < 0) return "The enemies are South";
            if(x > 0 && y > 0) return "The enemies are NorthEast";
            if(x > 0 && y == 0) return "The enemies are East";
            if(x > 0 && y < 0) return "The enemies are SouthEast";
            return "unknown position";
    }
    //ToString
    public override string ToString()
    {
        return $"{whereIsTheEnemy(x, y)}\n";
    }
    public static void Main()
    {
        Console.WriteLine("What is your X value?");
        int x = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("What is your Y value?");
        int y = Convert.ToInt16(Console.ReadLine());

        WatchTower war = new WatchTower(x, y);
        Console.WriteLine(war);
    }
}