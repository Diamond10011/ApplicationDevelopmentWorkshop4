namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an instance of Calculator and call its methods
            Calculator cal = new Calculator();
            Calculator.PrintWelcome(); // static method call
            Console.WriteLine(cal.Add(5, 10));
            Console.WriteLine(cal.Multiply(5)); // uses default value for num2
            Console.WriteLine(cal.Multiply(5, 3)); // provides value for num2
        }
    }
}
