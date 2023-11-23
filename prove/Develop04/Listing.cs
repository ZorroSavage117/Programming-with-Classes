using System.Diagnostics;

public class Listing : Activity
{
    private int _sessionLength;
    private string[] _promt = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private int ran_num = new Random().Next(0, 4);

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Starting Listing Activity");
        Console.WriteLine("\nThis activity will help you reflect on times in your life.\n");
        Console.Write("How long, in seconds, would you like to do this activity for?");
        _sessionLength = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Starting activity in 5 seconds.");
        base.DisplaySpinningLine(5);

        Console.WriteLine();
        Console.WriteLine("List as many items to the following promt:");
        Console.WriteLine("--- {0} ---", _promt[ran_num]);
        Console.WriteLine("You may begin in: ");
        base.CountDown(5);
        base.StartTimer(_sessionLength);

        Listin();
    }

    public void Listin()
    {
        while (!IsTimeUp())
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item == "stop")
            {
                break;
            }
        }
        Stop();
    }

    public void Stop()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Well done! You have completed the listing activity.");
        Console.WriteLine("You have completed the listing activity for {0} seconds.", _sessionLength);
        Thread.Sleep(1000);
        base.Menu();
    }
}