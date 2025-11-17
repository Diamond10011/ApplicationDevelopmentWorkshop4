namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the ParameterDemo class
            ParameterDemo demo = new ParameterDemo();
            // Calling Increase method (ref parameter)
            int number = 5;
            Console.WriteLine($"Initial value of variable: {number}");
            demo.Increase(ref number);
            Console.WriteLine("Value after Increase method: " + number);
            // Calling GetFullName method (out parameter)
            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name: " + fullName);
            // Calling SumAll method (params parameter)
            int sum1 = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum 1 (list of numbers): {sum1}");
            // OR using an array
            int[] data = { 100, 200, 300 };
            int sum2 = demo.SumAll(data);
            Console.WriteLine($"Sum 2 (array): {sum2}");
        }
    }
}