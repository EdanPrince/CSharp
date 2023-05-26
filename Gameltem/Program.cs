using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Gameltem
{
    protected string name;
    protected int level;
    protected int score;
    public Gameltem(string name, int level, int score)
    {
        this.name = name;
        this.level = level;
        this.score = score;
    }
    public abstract void DisplayInfo();
}
public class Weapon : Gameltem
{
    protected int damage;

    public Weapon(string name, int level, int score, int damage)
        : base(name, level, score)
    {
        this.damage = damage;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Weapon: {name}, Level: {level}, Score: {score}, Damage: {damage}");
    }

    public void Attack()
    {
        Console.WriteLine("Attacking with the weapon!");
    }
}
public class Armor : Gameltem
{
    protected int defense;

    public Armor(string name, int level, int score, int defense)
        : base(name, level, score)
    {
        this.defense = defense;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Armor: {name}, Level: {level}, Score: {score}, Defense: {defense}");
    }

    public void Defend()
    {
        Console.WriteLine("Defending with the armor!");
    }
}
public class Consumable : Gameltem
{
    protected int healthPoints;

    public Consumable(string name, int level, int score, int healthPoints)
        : base(name, level, score)
    {
        this.healthPoints = healthPoints;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Consumable: {name}, Level: {level}, Score: {score}, Health Points: {healthPoints}");
    }

    public void Use()
    {
        Console.WriteLine("Using the consumable!");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Weapon weapon = new Weapon("Sword", 10, 100, 50);
        Armor armor = new Armor("Shield", 5, 50, 20);
        Consumable consumable = new Consumable("Health Potion", 1, 10, 25);

        weapon.DisplayInfo();
        armor.DisplayInfo();
        consumable.DisplayInfo();
        weapon.Attack();
        armor.Defend();
        consumable.Use();
    }
}

