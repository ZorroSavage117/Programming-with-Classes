public class Outdoor : Event
{
    private string _weather;
    
    public Outdoor(string event_title, Address address, string date, string time, string description, string weather) : base(event_title, address, date, time, description)
    {
        _weather = weather;
    }

    public string Get_Weather()
    {
        return _weather;
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
            Console.WriteLine($"Weather: {Get_Weather()}");
        }
        else if (type == 3)
        {
            // Short description - Lists the type of event, title, and the date.
            Console.WriteLine($"Type: Outdoor");
            Console.WriteLine($"{Display_Format(type)}");
        }
    }

}