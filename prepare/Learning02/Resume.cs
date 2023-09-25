public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write($"Jobs: ");
        foreach (Job x in _jobs) 
        Console.Write(x.Display());
        Console.WriteLine();
    }
}