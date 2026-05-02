using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string uName = AskName();
        int uNumber = AskNumber();
        int squaredNumber = SquareNumber(uNumber);
        int birthYear;
        AskBirthYear(out birthYear);
        DisplayResult(uName, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the system.");
    }

    static string AskName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int AskNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static void AskBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
}