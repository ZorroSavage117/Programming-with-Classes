public class WritignAssign : Assignment
{
    private string title;

    public WritignAssign(string student_name_in, string topic_in, string title_in) : base(student_name_in, topic_in)
    {
        title = title_in;
    }

    public string Get_writing_info()
    {
        string student_name = Get_student_name();
        string summery = $"{title} by {student_name}";
        return summery;
    }
}

