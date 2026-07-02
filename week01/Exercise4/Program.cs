using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userAnswer = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userAnswer != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userAnswer = int.Parse(userResponse);

            if (userAnswer != 0)
            {
                numbers.Add(userAnswer);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sume is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

    }
}