using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment student1 = new Assignment("Samuel Bennett", "Multiplacation");
        MathAssign student2 = new MathAssign("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritignAssign student3 = new WritignAssign("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(student1.Get_summary());
        Console.WriteLine(student2.Get_summary());
        Console.WriteLine(student2.Get_homework_list());
        Console.WriteLine(student3.Get_summary());
        Console.WriteLine(student3.Get_writing_info());

    }
}