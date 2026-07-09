using System;

// Creativity: I added the day of the week to each journal entry
// The program stores, displays, saves, and loads this information along
// with the date, prompt, and response.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                
                string response = Console.ReadLine();

                Entry entry = new Entry();
                
                entry._promptText = prompt;
                entry._entryText = response;
                entry._date = DateTime.Now.ToShortDateString();
                entry._dayOfWeek = DateTime.Now.DayOfWeek.ToString();

                journal.AddEntry(entry);

                Console.WriteLine("Entry added!");
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded!");
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);

                Console.WriteLine("Journal saved!");
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}