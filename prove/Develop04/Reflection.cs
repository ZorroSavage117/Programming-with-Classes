public class Reflection : Activity
{
    private int _sessionLength;
    private string[] _promt1 = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless"};
    private string[] _promt2 = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
        "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"};
    private Random rand = new Random();

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Starting Reflection Activity");
        Console.WriteLine("\nThis activity will help you reflect on times in your life.\n");
        Console.Write("How long, in seconds, would you like to do this activity for?");
        _sessionLength = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Starting activity in 5 seconds.");
        base.DisplaySpinningLine(5);

        int ran_num = rand.Next(0, _promt1.Length);

        Console.WriteLine("Consider the following promt:");
        Console.WriteLine("--- {0} ---", _promt1[ran_num]);
        Console.WriteLine("Press enter to continue");
        string input = Console.ReadLine();
        base.StartTimer(_sessionLength);

        Console.Clear();
        reflect();
    }

    private void reflect()
    {
        while (!IsTimeUp())
        {
            Console.Write(_promt2[rand.Next(0, _promt2.Length)]);
            base.DisplaySpinningLine(7);
        }

        Stop();
    }

    public void Stop()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Well done! You have completed the reflection activity.");
        Console.WriteLine("You have completed the reflection activity for {0} seconds.", _sessionLength);
        Thread.Sleep(1000);
        base.Menu();
    }
}