using System.ComponentModel.DataAnnotations;

public class Receptions : Event
{
    private string _email;

    public Receptions(string event_title, Address address, string date, string time, string description, string email) : base(event_title, address, date, time, description)
    {
        _email = email;
    }

    public string Get_Email()
    {
        return _email;
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
            Console.WriteLine($"Email: {Get_Email()}");
        }
        else if (type == 3)
        {
            // Short description - Lists the type of event, title, and the date.
            Console.WriteLine($"Type: Reception");
            Console.WriteLine($"{Display_Format(type)}");
        }
    }

}