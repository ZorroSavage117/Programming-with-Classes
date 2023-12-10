using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("03 Nov 2022", 10, 5));
        activities.Add(new Cycling("28 Feb 2019", 10, 20));
        activities.Add(new Swimming("25 Dec 2023", 10, 10));
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}