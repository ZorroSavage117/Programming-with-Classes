using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        DateTime cur_date = new DateTime();
        Journal right_now = new Journal();

        while (keepRunning)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select on of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Dispaly");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice_in = Console.ReadLine();
            int choice = int.Parse(choice_in);
            
            if (choice == 1)
            {
                // run prompt
                right_now.Add_entry(cur_date);
            }
            else if (choice == 2)
            {
                // run display
                right_now.Display_all_entries();
            }
            else if (choice == 3)
            {
                // run load
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                right_now.Load_from_file(filename);
            }
            else if (choice == 4)
            {
                // run save
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                right_now.Save_to_file(filename);
            }
            else if (choice == 5)
            {
                keepRunning = false;
            }
        }
        
        
    }
}