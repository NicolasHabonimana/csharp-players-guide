// Written by Nicolas  
// 3/2/2025  

using System;

public class Chest
{
    // Variables
    private string state = "Locked";

    // Getters
    public string State
    {
        get { return state; }
    }

    // Full Constructor
    public Chest(string initialState)
    {
        state = initialState;
    }

    // Empty Constructor
    public Chest() : this("Locked") { }

    // Methods
    public void Open()
    {
        if (state == "Unlocked")
        {
            state = "Open";
            Console.WriteLine("You open the chest.");
        }
        else
        {
            Console.WriteLine("You can't open the chest right now.");
        }
    }

    public void Close()
    {
        if (state == "Open")
        {
            state = "Unlocked";
            Console.WriteLine("You close the chest.");
        }
        else
        {
            Console.WriteLine("You can't close the chest right now.");
        }
    }

    public void Lock()
    {
        if (state == "Unlocked")
        {
            state = "Locked";
            Console.WriteLine("You lock the chest.");
        }
        else
        {
            Console.WriteLine("You can't lock the chest right now.");
        }
    }

    public void Unlock()
    {
        if (state == "Locked")
        {
            state = "Unlocked";
            Console.WriteLine("You unlock the chest.");
        }
        else
        {
            Console.WriteLine("The chest is already unlocked.");
        }
    }

    public void StartGame()
    {
        while (true)
        {
            Console.WriteLine($"The chest is {State}. What do you want to do?");
            string command = Console.ReadLine().Trim().ToLower();

            switch (command)
            {
                case "open":
                    Open();
                    break;
                case "close":
                    Close();
                    break;
                case "lock":
                    Lock();
                    break;
                case "unlock":
                    Unlock();
                    break;
                default:
                    Console.WriteLine("Invalid command. Try: open, close, lock, unlock.");
                    break;
            }
        }
    }
}
