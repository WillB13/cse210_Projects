using System;

public class Game
{
    public void StartGame()
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("     MECH COMBAT SIMULATOR");
        Console.WriteLine("=================================");
        Console.WriteLine();

        Pilot player = new AssaultPilot(
            "Player",
            100,
            20,
            5);

        Enemy enemy = new Enemy(
            "Enemy Drone",
            80,
            15,
            2);

        Mission mission = new Mission(player, enemy);

        mission.StartMission();

        Console.WriteLine();
        Console.WriteLine("Game Over");
    }
}