public class Breathing : Activity
{
    private int _sessionLength;
    

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Starting Breathing Activity");
        Console.WriteLine("\nThis activity will help you relax by walking you through a breathing exercise.\n");
        Console.Write("How long, in seconds, would you like to do this activity for?");
        _sessionLength = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Starting activity in 5 seconds.");
        base.DisplaySpinningLine(5);


       base.StartTimer(_sessionLength);

        Breathe();
    }

   

    public void Breathe()
    {
        Console.Write("Breathe in...");
        base.CountDown(5);
        Console.WriteLine();

        Console.Write("Breathe out...");
        base.CountDown(5);
        Console.WriteLine();
    }

    public void Stop()
    {
        Console.WriteLine();
        Console.WriteLine("Well done! You have completed the breathing activity.");
        Console.WriteLine("You have completed the breathing activity for {0} seconds.", _sessionLength);
        Thread.Sleep(1000);
        base.Menu();
    }
}