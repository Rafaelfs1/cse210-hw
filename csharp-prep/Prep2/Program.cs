using System;

class Program
{
    static void Main(string[] args)
    {
        // input from user
        Console.Write("What's you grade percentage? ");
        string gradeByUser = Console.ReadLine();
        int grade = int.Parse(gradeByUser);

        // if statements
        // define var
        string msgAproved = "";
        string letter = "";

        // output the result
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // aproved or not
        if (grade >= 70)
        {
            msgAproved = "You passed!";
        }
        else
        {
            msgAproved = "Keep Trying"; 
        }

        // output
        Console.WriteLine($"Your grade is {letter}, {msgAproved} ");

    }
}