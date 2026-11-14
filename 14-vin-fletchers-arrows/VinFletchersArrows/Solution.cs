public class MainProgram
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Vin Fletcher's Arrow Shop!");

        // Choose Arrowhead
        Console.WriteLine("Choose an arrowhead type:");
        Console.WriteLine("1 – Steel\n2 – Wood\n3 – Obsidian");
        Console.Write("Enter choice: ");
        Arrowhead arrowhead = (Arrowhead)(Convert.ToInt16(Console.ReadLine()) - 1);

        // Choose Fletching
        Console.WriteLine("Choose a fletching type:");
        Console.WriteLine("1 – Plastic\n2 – Turkey Feathers\n3 – Goose Feathers");
        Console.Write("Enter choice: ");
        Fletching fletching = (Fletching)(Convert.ToInt16(Console.ReadLine()) - 1);

        // Choose Shaft Length
        float length;
        do
        {
            Console.Write("Enter shaft length (between 60-100 cm): ");
            length = Convert.ToSingle(Console.ReadLine());
        } while (length < 60 || length > 100);

        // Create Arrow Object and Display Cost
        Arrow arrow = new Arrow(arrowhead, fletching, length);
        Console.WriteLine(arrow);
    }
}
