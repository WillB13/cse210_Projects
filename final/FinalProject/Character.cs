using System;

public abstract class Character
{
    private string _name;
    private int _health;
    private int _damage;
    private int _armor;

    public Character(string name, int health, int damage, int armor)
    {
        _name = name;
        _health = health;
        _damage = damage;
        _armor = armor;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetHealth()
    {
        return _health;
    }

    public bool IsAlive()
    {
        return _health > 0;
    }

    public virtual void Attack(Character target)
    {
        Console.WriteLine($"{_name} attacks {target.GetName()}!");
        target.TakeDamage(_damage);
    }

    public virtual void UseAbility(Character target)
    {
        Console.WriteLine($"{_name} has no special ability.");
    }

    public void TakeDamage(int damage)
    {
        int finalDamage = damage - _armor;

        if (finalDamage < 1)
        {
            finalDamage = 1;
        }

        _health -= finalDamage;

        if (_health < 0)
        {
            _health = 0;
        }

        Console.WriteLine($"{_name} takes {finalDamage} damage. Health: {_health}");
    }

    public void DisplayStats()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"Health: {_health}");
        Console.WriteLine($"Damage: {_damage}");
        Console.WriteLine($"Armor: {_armor}");
    }
}