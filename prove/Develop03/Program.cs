using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("Genesis 1:1");
        Scripture scripture = new Scripture("In the beginning God created the heaven and the earth.");
        while (true)
        {
            Console.Clear();
            Console.Write(reference.GetReference() + " ");
            scripture.display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine(); // add method that checks if the scripture is blanked out
            if (input == "quit" || scripture.GetisBlankedOut())
            {
                break;
            }
            else
            {
                int count = 0;
                while (count < 4)
                {
                    scripture.blankingOut();
                    count++;
                }
            }
        }
    }
}