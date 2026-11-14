// Written by Nicolas
// 2/16/2025
using System;

public class SoupMaker
{
    // Variables
    private int soupChoice;
    private int ingredientChoice;
    private int seasoningChoice;

    // Constructor
    public SoupMaker(int _soupChoice, int _ingredientChoice, int _seasoningChoice)
    {
        soupChoice = _soupChoice;
        ingredientChoice = _ingredientChoice;
        seasoningChoice = _seasoningChoice;
    }

    // Method to return soup description
    public string ReturnSoup()
    {
        string soupType = soupChoice == 1 ? "Soup" : soupChoice == 2 ? "Stew" : soupChoice == 3 ? "Gumbo" : "Invalid Soup";
        string ingredient = ingredientChoice == 1 ? "Mushrooms" : ingredientChoice == 2 ? "Chicken" : ingredientChoice == 3 ? "Carrots" : ingredientChoice == 4 ? "Potatoes" : "Invalid Ingredient";
        string seasoning = seasoningChoice == 1 ? "Spicy" : seasoningChoice == 2 ? "Salty" : seasoningChoice == 3 ? "Sweet" : "Invalid Seasoning";

        if (soupType == "Invalid Soup" || ingredient == "Invalid Ingredient" || seasoning == "Invalid Seasoning")
            return "Invalid selection. Please try again.";

        return $"You made a {seasoning} {ingredient} {soupType}!";
    }
}
