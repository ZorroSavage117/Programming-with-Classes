public class Checklist : Goal
{

    private int times;
    private int completed;
    private bool finished;
    private int bonus_points;

    public Checklist() : base(" ", " ", 0, "Checklist") 
    {
        times = 0;
        completed = 0;
        finished = false;
        bonus_points = 0;
    }
    public Checklist(string name_in, string description_in, int points_in, int times_in, int completed_in, bool finished_in, int bonus_points_in) : base(name_in, description_in, points_in, "Checklist") 
    {
        times = times_in;
        completed = completed_in;
        finished = finished_in;
        bonus_points = bonus_points_in;
    }

    public void CreateChecklist()
    {
        Console.Write("What is the name of the goal? ");
        name = Console.ReadLine();
        Console.Write("What is the description of the goal? ");
        description = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be completed? ");
        times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for finishing this goal? ");
        bonus_points = int.Parse(Console.ReadLine());

    }

    public override void Set_completed()
    {
        completed++;
        Complete();
    }

    public override int Get_completed_c() { return completed; }

    public override bool Get_finished() { return finished; }

    public override int Get_times() { return times; }

    private void Complete()
    {
        if (completed == times)
        {
            finished = true;
        }
    }

    private string Finish()
    {
        if (finished)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    public override int Get_bonus()
    {
        if (finished)
        {
            Console.WriteLine("Congratulations! You have completed the goal!");
            Console.WriteLine("You have earned " + bonus_points + " bonus points!");
            return bonus_points;
        }
        else
        {
            return 0;
        }
    }

    public override int Get_bonus_points() { return bonus_points; }

    public override void Display()
    {
        Console.WriteLine("[" + Finish() + "] " + name + " (" + description + ") -- Currently completed " + completed + "/" + times);
    }
}