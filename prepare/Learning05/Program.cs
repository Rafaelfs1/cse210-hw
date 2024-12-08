using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Assignment class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        // Create an instance of the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "Problems 8-19");
        string mathSummary = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathSummary);
        

        // Create an instance of the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string authorName = writingAssignment.GetSummary();
        Console.WriteLine(authorName);
        string writingSummary = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingSummary);
    }
}