namespace Task5;

public class Program
{
    public static void Main(string[] args)
    {
        // Asking user to enter the day
        Console.WriteLine("Enter the Day"); // user should enter day in lowercase
        String input = Console.ReadLine(); // Read user input 
        // Using switch case to check the day type
        switch (input)
        {
            // Printing DayType based on user input
            case "sunday":
                Console.WriteLine($"It is a: {DayType.Weekday}");
                break;
            case "monday":
                Console.WriteLine($"It is a: {DayType.Weekday}");
                break;
            case "tuesday":
                Console.WriteLine($"It is a: {DayType.Weekday}");
                break;
            case "wednesday":
                Console.WriteLine($"It is a: {DayType.Weekday}");
                break;
            case "thursday":
                Console.WriteLine($"It is a: {DayType.Weekday}");
                break;
            case "friday":
                Console.WriteLine($"It is a: {DayType.Weekend}");
                break;
            case "saturday":
                Console.WriteLine($"It is a: {DayType.Weekend}");
                break;
            default:
                Console.WriteLine("Invalid day entered.");
                break;
        }
        // Create an object for book and assign the values.
        Book book1 = new Book("Godse", "Aditya Movies", 378);
        // Create another object and by using 'with' expression
        // change the title and price.
        Book book2 = book1 with { Title = "New Title", Price = 400 };
        // Print the value of first object.
        Console.WriteLine($"\nBook 1: {book1.Title} by {book1.Author}, Price: ${book1.Price}");
        // Deconstruct the second object into three variables and print them.
        (string title, string author, double price) = book2;
        Console.WriteLine($"\nDeconstructed book2 values:");
        Console.WriteLine($"  Title: {title}");
        Console.WriteLine($"  Author: {author}");
        Console.WriteLine($"  Price: ${price}");


    }
}