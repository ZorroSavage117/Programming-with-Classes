using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Variables
            int myNum = 0;
            int myNumEnd = 0;
            int guess = 0;
            string cont = "";
            bool runTf = true;
            bool gameTf = true;
            int guessNum = 0;
            int totalGuesses = 0;
            int numGames = 0;
            double gpg = 0;

            // Main code
            while (gameTf)
            {
                Random random = new Random();
                myNumEnd = random.Next(100, 1000001);
                myNum = random.Next(1, myNumEnd);
                guess = 0;
                guessNum = 0;

                Console.WriteLine($"Guess a number between 1 and {myNumEnd}");

                while (runTf)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess > myNum)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guess < myNum)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess == myNum)
                    {
                        Console.WriteLine("You got it.");
                        runTf = false;
                    }

                    guessNum++;
                }

                Console.WriteLine($"It took you {guessNum} tries");

                Console.Write("Do you want to play again? ");
                cont = Console.ReadLine();

                if (cont.ToLower() == "no")
                {
                    gameTf = false;
                }
                else
                {
                    runTf = true;
                }

                numGames++;
                totalGuesses += guessNum;
            }

            gpg = (double)totalGuesses / numGames;
            Console.WriteLine($"You played {numGames}.");
            Console.WriteLine($"Your total number of guesses was {totalGuesses}.");
            Console.WriteLine($"Your guesses per game was {gpg}");

            Console.WriteLine();
    }
}