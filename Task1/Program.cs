namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating first object
            Student s1 = new Student();
            s1.name = "Diamond";
            s1.age = 20;
            s1.address = "Gachhiya";

            // Creating second object
            Student s2 = new Student();
            s2.name = "Abhishek";
            s2.age = 19;
            s2.address = "Ithari";

            // Displaying details of first student
            Console.WriteLine("----- Student 1 -----");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Address: " + s1.address);

            // Displaying details of second student
            Console.WriteLine("\n----- Student 2 -----");
            Console.WriteLine($"Name: {s2.name}");
            Console.WriteLine($"Age: {s2.age}");
            Console.WriteLine($"Address: {s2.address}");

            // Displaying static field
            Console.WriteLine($"\nStatic Field: {Student.collegeName}");

        }
    }
}
