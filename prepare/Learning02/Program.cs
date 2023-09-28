using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        var job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        var job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        var resume1 = new Resume();
        resume1._name = "Zorro Savage";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // job1.Display();
        // job2.Display();
        resume1.Display();
    }
}