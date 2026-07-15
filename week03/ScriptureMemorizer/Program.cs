// Creativity: 
// 1. The program uses a scripture library and randomly selects a scripture
// for the user to memorize.
// 2. The program only selects words that have not already been hidden,
// preventing repeated selections and making the memorization process smoother.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        string text1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture1 = new Scripture(reference1, text1);

        Reference reference2 = new Reference("John", 3, 16);
        string text2 = "For God so loved the world that he gave his only begotten Son";
        Scripture scripture2 = new Scripture(reference2, text2);

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(scripture1);
        scriptures.Add(scripture2);

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            input = input.ToLower();

            if (input == "quit")
            {
                return;
            }
            else
            {
                scripture.HideRandomWords(2);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }    
}