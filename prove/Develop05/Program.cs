using System;
using System.Dynamic;
using System.Globalization;
using System.IO.Pipes;
using System.Xml.Schema;

class Program
{
    static List<Goal> goals = new List<Goal>();
    public static int totalPoints = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        
        while (true)
        {
            Console.WriteLine("You have " + totalPoints + " points.");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Progress");
            Console.WriteLine("6. Exit");
            Console.Write("Select choice from menu: ");
            string choice = Console.ReadLine();
            if (choice == "1") // Create a new goal
            {
                Console.WriteLine("The type of goals are:");
                Console.WriteLine("1. Simple");
                Console.WriteLine("2. Eternal");
                Console.WriteLine("3. Check List");
                Console.Write("Select choice from menu: ");
                choice = Console.ReadLine();
                if (choice == "1") // Simple
                {
                    Simple newGoal = new Simple();
                    newGoal.CreateSimple();
                    goals.Add(newGoal);
                }
                else if (choice == "2") // Eternal
                {
                    Eternal newGoal = new Eternal();
                    newGoal.CreateEternal();
                    goals.Add(newGoal);
                }
                else if (choice == "3") // Check List
                {
                    Checklist newGoal = new Checklist();
                    newGoal.CreateChecklist();
                    goals.Add(newGoal);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else if (choice == "2") // List Goals
            {
                ListGoals();
            }
            else if (choice == "3") // Save Goals
            {
                Console.Write("What file name would you like to save it to? ");
                string filename = Console.ReadLine();
                Save_to_file(filename + ".txt");

            }
            else if (choice == "4") // Load Goals
            {
                Console.Write("What file name would you like to load from? ");
                string filename = Console.ReadLine();
                Load_from_file(filename + ".txt");
            }
            else if (choice == "5") // Record Progress
            {
                RecordProgress();
            }
            else if (choice == "6") // Exit
            {
                break;
            }
            else if (choice == "404") // Testing choice that the user doesn't see
            {
                foreach (Goal goal in goals)
                {
                    if (goal.type == "Checklist")
                    {
                        Console.WriteLine($"{goal.type}<>{goal.name}<>{goal.description}<>{goal.points}<>{goal.Get_completed_c()}<>{goal.Get_times()}<>{goal.Get_finished()}<>{goal.Get_bonus_points()}");
                    }
                    else if (goal.type == "Simple")
                    {
                        Console.WriteLine($"{goal.type}<>{goal.name}<>{goal.description}<>{goal.points}<>{goal.Get_completed_s()}");
                    }
                    else if (goal.type == "Eternal")
                    {
                        Console.WriteLine($"{goal.type}<>{goal.name}<>{goal.description}<>{goal.points}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    static void AddPoints(int points)
    {
        totalPoints += points;
    }

    static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        int num = 1;
        foreach (var goal in goals)
        {
            Console.Write(num + ". ");
            goal.Display();
            num++;
        }
    }

    static void RecordProgress()
    {
        Console.WriteLine("Record Progress");
        ListGoals();
        Console.Write("Select goal to record progress: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice > 0 && choice <= goals.Count)
        {
            goals[choice - 1].Set_completed();
            AddPoints(goals[choice - 1].points);
            if (goals[choice - 1].type == "Checklist")
            {
                AddPoints(goals[choice - 1].Get_bonus());
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void Load_from_file(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        totalPoints = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            string[] parts = line.Split("<>");
            if (parts[0] == "Checklist")
            {
                // Console.WriteLine(goal.type + goal.name + goal.description + goal.points + goal.Get_completed_c() + goal.Get_times() + goal.Get_finished() + goal.Get_bonus());
                Checklist newGoal = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), bool.Parse(parts[6]), int.Parse(parts[7]));
                goals.Add(newGoal);
            }
            else if (parts[0] == "Simple")
            {
                // Console.WriteLine(goal.type + goal.name + goal.description + goal.points + goal.Get_completed_s());
                Simple newGoal = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                goals.Add(newGoal);

            }
            else if (parts[0] == "Eternal")
            {
                // Console.WriteLine(goal.type + goal.name + goal.description + goal.points);
                Eternal newGoal = new Eternal(parts[1], parts[2], int.Parse(parts[3]));
                goals.Add(newGoal);

            }
        }
    }

    static void Save_to_file(string filename)
    {
        using (StreamWriter stf = new StreamWriter(filename))
        {
            stf.WriteLine(totalPoints);
            foreach (Goal goal in goals)
            {
                if (goal.type == "Checklist")
                {
                    stf.WriteLine($"{goal.type}<>{goal.name}<>{goal.description}<>{goal.points}<>{goal.Get_completed_c()}<>{goal.Get_times()}<>{goal.Get_finished()}<>{goal.Get_bonus_points()}");
                }
                else if (goal.type == "Simple")
                {
                    stf.WriteLine($"{goal.type}<>{goal.name}<>{goal.description}<>{goal.points}<>{goal.Get_completed_s()}");
                }
                else if (goal.type == "Eternal")
                {
                    stf.WriteLine($"{goal.type}<>{goal.name}<>{goal.description}<>{goal.points}");
                }
            }
        }
    }
}