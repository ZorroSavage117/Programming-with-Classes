using System.Transactions;

public class Video
{
    private string _title;
    private string _creator;
    private int _length; // in seconds
    private List<Comment> _comments; // list of Comment objects

    public Video(string title, string creator, int length, List<Comment> comments)
    {
        _title = title;
        _creator = creator;
        _length = length;
        _comments = comments;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Creator
    {
        get { return _creator; }
        set { _creator = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public List<Comment> Comments
    {
        get { return _comments; }
        set { _comments = value; }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumComments()
    {
        return _comments.Count();
    }

    public void Display(Video video)
    {
        Console.WriteLine("Title: " + video._title);
        Console.WriteLine("Creator: " + video._creator);
        Console.WriteLine("Length: " + video._length + " seconds");
        Console.WriteLine("Comments:");
        foreach (Comment comment in video._comments)
        {
            Console.WriteLine(comment.Name + ": " + comment.Content);
        }
        Console.WriteLine();
    }

}