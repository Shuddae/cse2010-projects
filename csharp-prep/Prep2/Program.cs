using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What are your Grades?");
        string answer = Console.ReadLine();

        int percentage = int.Parse(answer);

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >=80)
        {
            letter = "B";
        }

        else if (percentage >=70)
        {
            letter = "C";
        }

        else if (percentage >=60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine("Your Grades are: {letter}");

        if (percentage >=70)
        {
            Console.WriteLine("You Passed");
        }

        else
        {
            Console.WriteLine("You have Failed, Better luck Next Time")
        }

    }
}