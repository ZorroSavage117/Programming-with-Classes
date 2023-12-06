public class Lectures : Event
{
    private string _speaker;
    private int _capasity;

    public Lectures(string event_title, Address address, string date, string time, string description, string speaker, int capasity) : base(event_title, address, date, time, description)
    {
        _speaker = speaker;
        _capasity = capasity;
    }

    public string Get_Speaker()
    {
        return _speaker;
    }

    public int Get_Capasity()
    {
        return _capasity;
    }   

    public void Display(int type)
    {
        if (type == 1)
        {
            // Standard details - Lists the title, description, date, time, and address.
            Console.WriteLine($"{Display_Format(type)}");
        }
        else if (type == 2)
        {
            // Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
            Console.WriteLine($"{Display_Format(type)}");
            Console.WriteLine($"Speaker: {Get_Speaker()}");
            Console.WriteLine($"Capasity: {Get_Capasity()}");
        }
        else if (type == 3)
        {
            // Short description - Lists the type of event, title, and the date.
            Console.WriteLine($"Type: Lectures");
            Console.WriteLine($"{Display_Format(type)}");
        }
    }

}