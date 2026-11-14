// Written by Nicolas
// Enumerations for Arrow Parts
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

public class Arrow
{
    // Auto-implemented read-only properties
    public Arrowhead ArrowheadType { get; }
    public Fletching FletchingType { get; }
    public float Length { get; }

    // Constructor
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        ArrowheadType = arrowhead;
        FletchingType = fletching;
        Length = length;
    }

    // Method to calculate the cost
    public float GetCost()
    {
        float arrowheadCost = ArrowheadType switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
            _ => 0
        };

        float fletchingCost = FletchingType switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3,
            _ => 0
        };

        float shaftCost = Length * 0.05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }

    // ToString() Method
    public override string ToString()
    {
        return $"Arrow with {ArrowheadType}, {FletchingType}, and {Length}cm shaft costs {GetCost():0.00} gold.";
    }
}

