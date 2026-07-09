using System;

public class Entry
{
    public string _date;
    public string _dayOfWeek;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
        Console.WriteLine($"Day: {_dayOfWeek}");
        Console.WriteLine();
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine();
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("-------------------------------------");
    }
}