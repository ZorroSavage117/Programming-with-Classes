
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


public class Eternal : Goal
{

    public Eternal() : base(" ", " ", 0, "Eternal") {}
    public Eternal(string name_in, string description_in, int points_in) : base(name_in, description_in, points_in, "Eternal") {}

    public void CreateEternal()
    {
        Console.Write("What is the name of the goal? ");
        name = Console.ReadLine();
        Console.Write("What is the description of the goal? ");
        description = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        points = int.Parse(Console.ReadLine());
    }

    public override void Set_completed() {}
    public override void Display()
    {
        Console.WriteLine("[ ] " + name + " (" + description + ")");
    }
}