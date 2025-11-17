using System;

namespace Task3;

public class ParameterDemo
{
    // Method using 'ref': Increases the original variable by 10.
    public void Increase(ref int number)
    {
        number += 10;
    }
    // Method using 'out': Assigns a value to the output variable.
    public void GetFullName(out string fullName)
    {
        fullName = "Diamond Baruwal";
    }
    // Method using 'params': Accepts a variable number of integer arguments.
    // Returns the sum of all numbers passed.
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("Sum: " + sum);
        return sum;
    }

}
