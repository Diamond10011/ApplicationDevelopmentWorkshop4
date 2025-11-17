using System;

namespace Task4;

public class Player
{
    // Instance Fields
    public String playerName;
    public int level;
    public String health;
    // Default Constructor
    // Runs when it's object is created
    public Player()
    {
        Console.WriteLine("Default Constructor has been called");
        playerName = "DefaultPlayer";
        level = 1;
        health = "Fit";
    }
    // Parameterized Constructor
    // Allows setting initial values for instance fields
    public Player(String playerName, int level, String health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }
}
