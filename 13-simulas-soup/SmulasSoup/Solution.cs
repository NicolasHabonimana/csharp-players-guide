public class MainProgram
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Simula's Soup Maker!");

        Console.WriteLine("Choose a soup type:");
        Console.WriteLine("1 – Soup");
        Console.WriteLine("2 – Stew");
        Console.WriteLine("3 – Gumbo");
        Console.Write("Enter your choice: ");
        int soupChoice = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Choose a main ingredient:");
        Console.WriteLine("1 – Mushrooms");
        Console.WriteLine("2 – Chicken");
        Console.WriteLine("3 – Carrots");
        Console.WriteLine("4 – Potatoes");
        Console.Write("Enter your choice: ");
        int ingredientChoice = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Choose a seasoning:");
        Console.WriteLine("1 – Spicy");
        Console.WriteLine("2 – Salty");
        Console.WriteLine("3 – Sweet");
        Console.Write("Enter your choice: ");
        int seasoningChoice = Convert.ToInt16(Console.ReadLine());

        // Create SoupMaker object and get result
        SoupMaker soup = new SoupMaker(soupChoice, ingredientChoice, seasoningChoice);
        Console.WriteLine(soup.ReturnSoup());
    }
}
