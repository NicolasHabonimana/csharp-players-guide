// Written by Nicolas

// Enumerations for Arrow Parts
enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

public class Arrow
{
    // Private Fields
    private readonly Arrowhead arrowhead;
    private readonly Fletching fletching;
    private readonly float length;

    // Constructor
    public Arrow(Arrowhead _arrowhead, Fletching _fletching, float _length)
    {
        arrowhead = _arrowhead;
        fletching = _fletching;
        length = _length;
    }

    // Getter Methods
    public Arrowhead GetArrowhead() => arrowhead;
    public Fletching GetFletching() => fletching;
    public float GetLength() => length;

    // Method to calculate the cost
    public float GetCost()
    {
        float arrowheadCost = arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
            _ => 0
        };

        float fletchingCost = fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3,
            _ => 0
        };

        float shaftCost = length * 0.05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }

    // ToString() Method
    public override string ToString()
    {
        return $"Arrow with {arrowhead}, {fletching}, and {length}cm shaft costs {GetCost():0.00} gold.";
    }
}
