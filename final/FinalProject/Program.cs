using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Mech Combat Simulator";

        Game game = new Game();
        game.StartGame();

        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}