using System.Timers;
public class Activity
{
    private System.Timers.Timer _timer;
    private bool _timeUp;

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start listing activity");
        Console.WriteLine("3. Start reflection activity");
        Console.WriteLine("4. Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Breathing breathing = new Breathing();
                breathing.Start();
                break;
            case 2:
                Listing listing = new Listing();
                listing.Start();
                break;
            case 3:
                Reflection reflection = new Reflection();
                reflection.Start();
                break;
            case 4:
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1000);
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice");
                Menu();
                break;
        }
    }

    public void DisplaySpinningLine(int seconds)
    {
        int counter = 0;
        while (counter < seconds * 2) // Display for twice the number of seconds (assuming half-second intervals)
        {
            counter++;
            Console.Write("\b{0}", GetSpinnerCharacter(counter));
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    private char GetSpinnerCharacter(int counter)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        return spinner[counter % spinner.Length];
    }

    public void CountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write("{0} ", i);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public void StartTimer(int seconds)
    {
        _timeUp = false;
        _timer = new System.Timers.Timer(seconds * 1000);
        _timer.Elapsed += TimerElapsed;
        _timer.AutoReset = false;
        _timer.Enabled = true;
    }

     private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        _timeUp = true;
    }

    public bool IsTimeUp()
    {
        return _timeUp;
    }
}