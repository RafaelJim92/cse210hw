using System;

class Program
{
    static void Main()
    {
        // Scripture reference for Alma 7:11-12
        Reference reference = new Reference("Alma", 7, 11, 12);
        Scripture scripture = new Scripture(reference, 
            "And he will take upon him death, that he may loose the bands of death which bind his people; " +
            "and he will take upon him their infirmities, that his bowels may be filled with mercy, " +
            "according to the flesh, that he may know according to the flesh how to succor his people " +
            "according to their infirmities.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(1); // Hide one random word
        }

        Console.WriteLine("All words are hidden. Press any key to exit.");
        Console.ReadKey();
    }
}
