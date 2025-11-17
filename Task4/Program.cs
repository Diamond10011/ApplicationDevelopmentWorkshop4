namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Player objects
            // When player1 is created, Default Constructor is called
            Player player1 = new Player();
            Console.WriteLine($"Player1 - Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");

            // Initialize player2 with Parameterized Constructor
            Player player2 = new Player("Hero", 5, "Healthy");
            Console.WriteLine($"Player2 - Name: {player2.playerName}, Level: {player2.level}, Health: {player2.health}");
        }
    }
}