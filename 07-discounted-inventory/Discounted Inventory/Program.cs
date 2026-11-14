//written by nicolas
//3/2/2025
public class BuyingInventory
{
    //variables
    private int itemNumber = -1;
    private string userName = "n/a";
    //gets and sets
    public int ItemNumber
    {
        get{return this.itemNumber;}
        set{this.itemNumber = value;}
    }
    public string UserName
    {
        get{return this.userName;}
        set{this.userName = value;}
    }
    //full constructor
    public BuyingInventory(int _itemNumber, string _userName)
    {
        itemNumber =_itemNumber;
        userName = _userName;
    }
    //empty constructor
    public BuyingInventory() : this(-1, "n/a"){}
    //methods
    public static void Main()
    {
        Console.WriteLine("The following items are available:\n1 – Rope\n2 – Torches\n3 – Climbing Equipment\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies\nWhat number do you want to see the price of?");
        int itemNumber = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("What is your Name?");
        string userName = Convert.ToString(Console.ReadLine());
        BuyingInventory shop = new BuyingInventory(itemNumber, userName);
        Console.WriteLine(shop);
    }
    public string returnProduct(int itemNumber, string userName)
    {
        int price = 0;
        string product = "";
        if(itemNumber == 1){product = "Rope"; price = 10;}
        if(itemNumber == 2){product = "Torches"; price = 15;}
        if(itemNumber == 3){product = "Climbing equipment"; price = 25;}
        if(itemNumber == 4){product = "Clean Water"; price = 1;}
        if(itemNumber == 5){product = "Machete"; price = 20;}
        if(itemNumber == 6){product = "Canoe"; price = 250;}
        if(itemNumber == 7){product = "Food Suplies"; price = 1;}
        if(userName.Equals("Nicolas")){price /= 2;}
        return $"{product} costs {price} gold.";
    }

    //ToString() Method
    public override string ToString()
    {
        return $"{returnProduct(itemNumber, userName)}\n";
    }
}