using System;

public class Mission
{
    private Pilot _player;
    private Enemy _enemy;

    public Mission(Pilot player, Enemy enemy)
    {
        _player = player;
        _enemy = enemy;
    }

    public void StartMission()
    {
        Console.WriteLine();
        Console.WriteLine("Mission Started!");
        Console.WriteLine();

        while (_player.IsAlive() && _enemy.IsAlive())
        {
            PlayerTurn();

            if (_enemy.IsAlive())
            {
                EnemyTurn();
            }
        }

        if (_player.IsAlive())
        {
            Console.WriteLine("Mission Complete!");
        }
        else
        {
            Console.WriteLine("Mission Failed.");
        }
    }

    private void PlayerTurn()
    {
        Console.WriteLine();
        Console.WriteLine("Your Turn");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Ability");

        string choice = Console.ReadLine();

        if (choice == "2")
        {
            _player.UseAbility(_player);
        }
        else
        {
            _player.Attack(_enemy);
        }
    }

    private void EnemyTurn()
    {
        Console.WriteLine();
        Console.WriteLine("Enemy Turn");

        _enemy.Attack(_player);
    }
}