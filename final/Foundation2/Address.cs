public class Address
{
    private string _location;

    public Address(string location) 
    {
        // in this format: Aaron> 1234 Main St> Anytown, state zip> USA
        _location = location;
    }
    
    public string USA_Location()
    {
        string[] parts = _location.Split('>');
        return parts[3];
    }

    public string Format()
    {   
        string[] parts = _location.Split('>');
        return $"{parts[0]}\n{parts[1]}\n{parts[2]}\n{parts[3]}";
    }
}