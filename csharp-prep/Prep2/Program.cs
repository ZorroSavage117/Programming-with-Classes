using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // variables
        int gradePercent = 0;
        int lastDigit = 0;
        string letterGrade = "";
        string gradeHalf = "";
        string passing = "";
        string outcome = "";

        // main code
        // user input
        Console.Write("What is your grade percentage? ");
        gradePercent = Convert.ToInt32(Console.ReadLine());

        // calculation
        lastDigit = gradePercent % 10;

        // if statements

        // letter grade
        if (gradePercent >= 90)
        {
            letterGrade = "A";
            passing = "y";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
            passing = "y";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
            passing = "y";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
            passing = "n";
        }
        else
        {
            letterGrade = "F";
            passing = "n";
        }

        // is it + or -
        if (lastDigit >= 7)
        {
            gradeHalf = "+";
        }
        else if (lastDigit < 3)
        {
            gradeHalf = "-";
        }
        else
        {
            gradeHalf = "";
        }

        // there is no A+
        if (letterGrade == "A" && (gradeHalf == "+" || gradePercent >= 100))
        {
            gradeHalf = "";
        }

        // there is no F+ or F-
        if (letterGrade == "F")
        {
            gradeHalf = "";
        }

        // are they passing and what should I say to them
        if (passing == "y")
        {
            outcome = "Congratulations, you are passing.";
        }
        else
        {
            outcome = "Keep trying, you got this.";
        }

        // output
        Console.WriteLine($"You have a(n) {letterGrade}{gradeHalf}. {outcome}");
    }
}