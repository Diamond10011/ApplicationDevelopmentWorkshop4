using System;

namespace Task2;

public class Calculator
{
    public static void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator!");
    }
    // method to add two numbers
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    // method to multiply two numbers with default value for second parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
