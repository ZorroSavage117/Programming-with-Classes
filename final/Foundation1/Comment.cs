public class Comment
{
    private string _name;
    private string _content;

    public Comment(string name, string content)
    {
        _name = name;
        _content = content;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Content
    {
        get { return _content; }
        set { _content = value; }
    }
    
}