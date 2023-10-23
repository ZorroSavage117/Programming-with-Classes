public class MathAssign : Assignment
{
    private string textbook_section;
    private string problems;

    public MathAssign(string student_name_in, string topic_in, string textbook_section_in, string problems_in) : base(student_name_in, topic_in)
    {
        textbook_section = textbook_section_in;
        problems = problems_in;
    }

    public string Get_homework_list()
    {
        string summery = $"{textbook_section} {problems}";
        return summery;
    }
}

