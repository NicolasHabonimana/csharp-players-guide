//written by nicolas
//3/2/2025
public class BuyingInventory
{
    //variables
    private int itemNumber = -1;
    //gets and sets
    public int ItemNumber
    {
        get{return this.itemNumber;}
        set{this.itemNumber = value;}
    }
    //full constructor
    public BuyingInventory(int _itemNumber)
    {
        itemNumber =_itemNumber;
    }
    //empty constructor
    public BuyingInventory() : this(-1){}
    //methods
    public static void Main()
    {
        Console.WriteLine("The following items are available:\n1 – Rope\n2 – Torches\n3 – Climbing Equipment\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies\nWhat number do you want to see the price of?");
        int itemNumber = Convert.ToInt16(Console.ReadLine());
        BuyingInventory shop = new BuyingInventory(itemNumber);
        Console.WriteLine(shop);
    }
    public string returnProduct(int itemNumber)
    {
        if(itemNumber == 1) return "Ropes cost 10 gold";
        if(itemNumber == 2) return "Torches cost 15 gold";
        if(itemNumber == 3) return "Climbing equipments cost 25 gold";
        if(itemNumber == 4) return "Clean Water cost 1 gold";
        if(itemNumber == 5) return "Machetes cost 20 gold";
        if(itemNumber == 6) return "Canoe cost 200 gold";
        if(itemNumber == 7) return "Food Suplies cost 1 gold";
        return "Invalid Input";
    }
    //ToString() Method
    public override string ToString()
    {
        return $"{returnProduct(itemNumber)}\n";
    }
}