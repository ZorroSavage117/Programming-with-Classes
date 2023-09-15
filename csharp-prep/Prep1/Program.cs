using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        //String interpolation
        int myInt = 5;
        Console.WriteLine("my int = " + myInt);
        Console.WriteLine($"my int = {myInt}");

        //ReadLine
        Console.WriteLine("What is your first name?"); 
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        //Conditionals
        // if (name == "Arlo")
        // {
        //     Console.WriteLine("Hey thats me");
        // }
        // else
        // {
        //     Console.WriteLine($"Hi there, {name}");
        // }

    }
}