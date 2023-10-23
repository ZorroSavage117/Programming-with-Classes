public class Assignment
{
    private string student_name;
    private string topic;

    public Assignment(string student_name_in, string topic_in)
    {
        student_name = student_name_in;
        topic = topic_in;
    }

    public string Get_summary()
    {
        string summery = $"{student_name} - {topic}";
        return summery;
    }

    public string Get_student_name()
        {
            return student_name;
        }

}

