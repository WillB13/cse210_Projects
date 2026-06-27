using System;

class Program
{
    static Goal[] goals = new Goal[100];
    static int goalCount = 0;
    static int score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("> ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                running = false;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\n1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("> ");

        string type = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals[goalCount] = new SimpleGoal(name, desc, points);
        }
        else if (type == "2")
        {
            goals[goalCount] = new EternalGoal(name, desc, points);
        }
        else if (type == "3")
        {
            Console.Write("Target times: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            goals[goalCount] = new ChecklistGoal(name, desc, points, target, bonus);
        }

        goalCount++;
    }

    static void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < goalCount; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        score += goals[index].RecordEvent();
        Console.WriteLine($"Score: {score}");
    }
}