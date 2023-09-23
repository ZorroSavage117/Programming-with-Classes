using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
            // Variables
            string numInput = "";
            List<int> numList = new List<int>();
            int maxNum = 0;
            double aveNum = 0;
            int sumNum = 0;
            bool inputValid = true;

            // Main code
            // List input
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            while (inputValid)
            {
                numInput = Console.ReadLine();
                int num;
                if (int.TryParse(numInput, out num))
                {
                    if (num == 0)
                    {
                        inputValid = false;
                    }
                    else
                    {
                        numList.Add(num);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Sum of the list
            foreach (int num in numList)
            {
                sumNum += num;
            }

            // Average of the list
            if (numList.Count > 0)
            {
                aveNum = (double)sumNum / numList.Count;
            }

            // Biggest value in the list
            foreach (int num in numList)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            // Output
            Console.WriteLine($"The sum is: {sumNum}");
            Console.WriteLine($"The average is: {aveNum}");
            Console.WriteLine($"The largest number is: {maxNum}");
    }
}