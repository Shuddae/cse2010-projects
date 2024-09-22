using System;

class Program
{
    static void Main(string[] args)
    {
        list<int> numbers = new list<int>();

        int userNumber = 10;
        while (userNumber !=0)
        {
            Console.Write("Enter a number (0 to qit):");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber !=0)
            {
                 number.Add(userNumber);
            }


        }
        int SUM = 0;
        foreach (var item in collection)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
       
}