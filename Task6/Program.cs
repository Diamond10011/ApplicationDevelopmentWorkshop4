namespace Task6;

public class Program
{
    public static void Main(string[] args)
    {
        // Ask the user to input marks.
        Console.WriteLine("Enter the marks:");
        bool s1 = false;
        int marks = 0;
        // Using a loop to ensure valid input
        while (!s1)
        {
            // Using TryParse for safe input
            s1 = int.TryParse(Console.ReadLine(), out marks);
            // if user input is invalid loop will continue
            if (!s1)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for marks:");
            }
        }
        // Console.WriteLine($"{s1} and {marks}");

        // Ask the user to input total.
        Console.WriteLine("Enter the Total:");
        bool s2 = false;
        int total = 0;
        // Same as above, using a loop to ensure valid input
        while (!s2)
        {
            s2 = int.TryParse(Console.ReadLine(), out total);
            if (!s2)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for marks:");
            }
        }
        // Console.WriteLine($"{s2} and {total}");
        // Calculate the Percentage
        double percentage = marks / total * 100;
        // Print the Percentage
        Console.WriteLine($"Percentage: {percentage}%");

        /*
        *The output is not coming as expected because of integer division.
        *In C#, when you divide two integers, the result is also an integer, which means any decimal part is truncated.
        *To fix this, we need to ensure that at least one of the operands in the division is a double or float.
        */
        // Corrected Calculation
        double correctPercentage = (double)marks / total * 100;
        Console.WriteLine($"Corrected Percentage: {correctPercentage}%");

    }

}