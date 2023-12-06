using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Lectures lecture = new Lectures("Lecture", new Address("Aaron> 1234 Main St> Anytown, state zip> USA"), "December 10, 2025", "10:30am", "random text because mind can't think", "Bob Bobby", 100);
        Receptions reception = new Receptions("Reception", new Address("Aaron> 1234 Main St> Anytown, state zip> USA"), "12/31/2023", "Midnight", "Rando text for fried brain", "rando@email.com");
        Outdoor outdoor = new Outdoor("Outdoor", new Address("Aaron> 1234 Main St> Anytown, state zip> USA"), "Febuwary 31, 2024", "12:70pa", "description", "unknown");

        lecture.Display(1);
        Console.WriteLine();
        lecture.Display(2);
        Console.WriteLine();
        lecture.Display(3);
        Console.WriteLine();
        reception.Display(1);
        Console.WriteLine();
        reception.Display(2);
        Console.WriteLine();
        reception.Display(3);
        Console.WriteLine();
        outdoor.Display(1);
        Console.WriteLine();
        outdoor.Display(2);
        Console.WriteLine();
        outdoor.Display(3);
    }
}