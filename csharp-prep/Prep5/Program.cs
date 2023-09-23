using System;

class Program
{
    static void Displaywelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromtUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromtUserNumber()
    {
        Console.Write("Please ebter your favorite number: ");
        int num = Convert.ToInt16(Console.ReadLine());
        return num;
    }
    static int SqureNumber(int num)
    {
        int result = num * num;
        return result;
    }
    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Displaywelcome();
        string name = PromtUserName();
        int num = PromtUserNumber();
        int num_squared = SqureNumber(num);
        DisplayResult(name, num_squared);
    }
}