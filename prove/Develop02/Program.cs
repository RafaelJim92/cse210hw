using System;
using System.Collections.Generic;

namespace DailyJournal
{
    class Program
    {
        private static readonly Random random = new Random();
        private static readonly List<string> prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you could do one thing over today, what would it be?",
            "Did anything unexpected happen today that surprised you?",
            "What was the most challenging thing you faced today and how did you overcome it?",
            "What was the best moment of your day and why?",
            "Who did you share a special moment with today?",
            "Did you discover anything new or learn something interesting today?",
            "Did someone make you feel special or make you smile today?",
            "Did you achieve any success in your work, studies, or personal projects today?",
            "Did you do anything today that took you out of your comfort zone?",
            "What would you like to do more of in your daily life and how do you plan to achieve it?",
            "What do you most wish for tomorrow?",
            "How did you show love or compassion towards others today?",
            "Did you receive any unexpected blessings today that you attribute to your faith?",
            "What was the most inspiring thing you heard or read today that strengthened your faith?",
          
        };

        static void Main(string[] args)
        {
            Journal journal = new Journal();

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Daily Journal Program");
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display all entries");
                Console.WriteLine("3. Save entries to a file");
                Console.WriteLine("4. Load entries from a file");
                Console.WriteLine("5. Quit the program");

                Console.Write("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt();
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            Console.WriteLine("Thank you for using the Daily Journal. Goodbye!");
        }

        static string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
