using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        // create a list 
        List<int> numbers = new List<int>();

        // define a data to compare
        int newNumber = -1;


        // loop to colect the number's list
        while (newNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");
            newNumber = int.Parse(Console.ReadLine());

            numbers.Add(newNumber); 
        }

            
        // sum ---------------------------------------
        int sum = 0;

        // look at each element and sum it
        foreach (int number in numbers)
        {
            sum += number;
        }

        // display the final result
        Console.WriteLine($"The Sum is: {sum}");

        // avarage ------------------------------------------
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // largest number
        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
    }
}