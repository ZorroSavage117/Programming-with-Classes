public class Event
{
    private string _event_title;
    private Address _address;
    private string _date;
    private string _time;
    private string _description;

    public Event(string event_title, Address address, string date, string time, string description)
    {
        _event_title = event_title;
        _address = address;
        _date = date;
        _time = time;
        _description = description;
    }

    public string Get_Event_Title()
    {
        return _event_title;
    }

    public string Get_Address()
    {
        return _address.Format();
    }

    public string Get_Date()
    {
        return _date;
    }

    public string Get_Time()
    {
        return _time;
    }

    public string Get_Description()
    {
        return _description;
    }

    public string Display_Format(int type)
    {
        if (type == 1)
        {
            // Standard details - Lists the title, description, date, time, and address.
            return $"Title: {Get_Event_Title()}\nDescription: {Get_Description()}\nDate: {Get_Date()}\nTime: {Get_Time()}\nAddress: {Get_Address()}";
        }
        else if (type == 2)
        {
            // Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
            return $"Title: {Get_Event_Title()}\nDescription: {Get_Description()}\nDate: {Get_Date()}\nTime: {Get_Time()}\nAddress: {Get_Address()}";
        }
        else
        {
            // Short description - Lists the type of event, title, and the date.
            return $"Title: {Get_Event_Title()}\nDate: {Get_Date()}";
        }
    
    }
    
}