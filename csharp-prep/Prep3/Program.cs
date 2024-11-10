using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // get a input from user to define the magic number and the guess
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // random the magicNumber value
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);

        // define the first guess
        int guess = -1;
        int counter = 0;
        string again = "";


        // logical if stantement
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            counter += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine($"You guessed it! ({counter} trys)");
                
            } 
        }


    }
}