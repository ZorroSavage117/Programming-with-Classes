using System.Diagnostics.Contracts;
using System.Dynamic;


public abstract class Goal
{
    public string type;
    public string name;
    public string description;
    public int points;

    public Goal()
    {
        name = " ";
        description = " ";
        points = 0;
        type = " ";
    }

    public Goal(string name_in, string description_in, int points_in, string type_in)
    {
        name = name_in;
        description = description_in;
        points = points_in;
        type = type_in;
    }

    public void Completed()
    {
        if (type == "Simple")
        {
            Simple simple = new Simple(name, description, points, false);
            simple.Set_completed();
        }
        else if (type == "Eternal") {}
        else if (type == "Checklist")
        {
            Checklist checklist = new Checklist(name, description, points, 0, 0, false, 0);
            checklist.Set_completed();
        }
    }

    public virtual bool Get_completed_s() { return false; }
    public virtual int Get_completed_c() { return 0; }
    public virtual bool Get_finished() { return false; }
    public virtual int Get_times() { return 0; }
    public virtual int Get_bonus_points() { return 0; }
    public virtual int Get_bonus() { return 0; }
    public abstract void Set_completed();
    public abstract void Display();
}