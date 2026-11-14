//written by Nicolas
// 1/28
using System.Reflection;
using Microsoft.VisualBasic;

public class GreatestKingdom
{
    //variables
    private int melikProvince = -1;
    private int melikDutchies = -1;
    private int melikEstates = -1;
    private int casikProvince = -1;
    private int casikDutchies = -1;
    private int casikEstates = -1;

    //gets & sets

    
    public int MelikProvince
    {
        get{return this.melikProvince;}
    }
    public int MelikDutchies
    {
        get{return this.melikDutchies;}
        set{this.melikDutchies = value;}
    }
    public int MelikEstates
    {
        get{return this.melikEstates;}
        set{this.melikEstates = value;}
    }
    public int CasikProvince
    {
        get{return this.casikProvince;}
    }
    public int CasikDutchies
    {
        get{return this.casikDutchies;}
        set{this.casikDutchies = value;}
    }
    public int CasikEstates
    {
        get{return this.casikEstates;}
        set{this.casikEstates = value;}
    }
    //full constructor
    public GreatestKingdom(int _melikProvince, int _melikDutchies, int _melikEstates, int _casikProvince, int _casikDutchies, int _casikEstates)
    {
        melikDutchies = _melikDutchies;
        melikProvince = _melikProvince;
        melikEstates = _melikEstates;
        casikDutchies = _casikDutchies;
        casikProvince = _casikProvince;
        casikEstates = _casikEstates;
    }
    //empty constructor
    public GreatestKingdom(): this(-1, -1, -1, -1, -1, -1){}
    
    //methods
    public int melikProvincePoints(int melikProvince)
    {
        int melikProvincePoint = (MelikProvince * 6);
        return melikProvincePoint;
    }
    public int casikProvincePoints(int casikProvince)
    {
        int casikProvincePoint = (casikProvince * 6);
        return casikProvincePoint;
    }
    public int melikDutchiesPoints(int melikDutchies)
    {
        int melikDutchiesPoint = (melikDutchies *3);
        return melikDutchiesPoint;
    }
    public int casikDutchiesPoints(int casikDutchies)
    {
        int casikDutchiesPoint = (casikDutchies *3);
        return casikDutchiesPoint;
    }
    public int melikEstatesPoints(int melikEstates)
    {
        int melikEstatesPoint = (melikEstates * 1);
        return melikEstatesPoint;
    }
    public int casikEstatesPoints(int casikEstates)
    {
        int casikEstatesPoint = (casikEstates * 1);
        return casikEstatesPoint;
    }
    public int melikTotalPoints()
    {
        int melikTotal = melikProvincePoints(melikProvince) + melikDutchiesPoints(melikDutchies) + melikEstatesPoints(melikEstates);
        return melikTotal;
    }
    public int casikTotalPoints()
    {
        int casikTotal = casikProvincePoints(casikProvince) + casikDutchiesPoints(casikDutchies) + casikEstatesPoints(casikEstates);
        return casikTotal;
    }
    public static void Main()
    {
        //king melik
        Console.WriteLine("How many Provinces does King Melik have?");
        int melikProvinces = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("How many Dutchies does King Melik have?");
        int melikDutchies = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("How many Estates does King Melik have?");
        int melikEstates = Convert.ToInt16(Console.ReadLine());
        //king casik
        Console.WriteLine("How many Provinces does King Casik have?");
        int casikProvinces = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("How many Dutchies does King Casik have?");
        int casikDutchies = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("How many Estates does King Casik have?");
        int casikEstates = Convert.ToInt16(Console.ReadLine());

        GreatestKingdom KingsPoints = new GreatestKingdom(melikProvinces, melikDutchies, melikEstates, casikProvinces, casikDutchies, casikEstates);
        Console.WriteLine(KingsPoints);
    }
    public override string ToString()
    {
        return $"King Melike has {melikTotalPoints()} points and King Casik has {casikTotalPoints(1)} points";
    }
}