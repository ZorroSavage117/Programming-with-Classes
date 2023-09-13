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
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"name = {name}");

        //Conditionals
        if (name == "Arlo")
        {
            Console.WriteLine("Hey thats me");
        }
        else
        {
            Console.WriteLine($"Hi there, {name}");
        }

    }
}