
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


public class Simple : Goal
{
    
    private bool completed;

    public Simple() : base(" ", " ", 0, "Simple") 
    {
        completed = false;
    }
    public Simple(string name_in, string description_in, int points_in, bool completed_in) : base(name_in, description_in, points_in, "Simple") 
    {
        completed = completed_in;
    }

    public void CreateSimple()
    {
        Console.Write("What is the name of the goal? ");
        name = Console.ReadLine();
        Console.Write("What is the description of the goal? ");
        description = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        points = int.Parse(Console.ReadLine());
    }

    private string Complete()
    {
        if (completed)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    public override void Set_completed()
    {
        completed = true;
    }

    public override bool Get_completed_s() { return completed; }

    public override void Display()
    {
        Console.WriteLine("[" + Complete() + "] " + name + " (" + description + ")");
    }
}