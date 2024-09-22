using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptuserName();
        int userNumber = PromptuserName();

        int squaredName = SquareNumber(userName);

        DisplayResult(userName,squaredName);
    }

    static void DisplayWelcomeMessage();
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptuserName()
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptuserNumber();
    {
        Console.Write("You may type your number:");
        int number = Console.ReadLine();

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}