using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add new journal entry
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    
                    // Generate a random number between 1 and 100
                    Random randomGenerator = new Random();
                    int magicNumber = randomGenerator.Next(1, 5);  // 1 to 5

                    string promptText = "";
                    string entryText = "";

                    if (magicNumber == 1)
                    {
                        promptText = "Who was the most interesting person I interacted with today? ";
                        Console.Write(promptText);
                        entryText = Console.ReadLine();
                    }

                    else if (magicNumber == 2)
                    {
                        promptText = "What was the best part of my day? ";
                        Console.Write(promptText);
                        entryText = Console.ReadLine();
                    }

                    else if (magicNumber == 3)
                    {
                        promptText = "How did I see the hand of the Lord in my life today? ";
                        Console.Write(promptText);
                        entryText = Console.ReadLine();
                    }

                    else if (magicNumber == 4)
                    {
                        promptText = "What was the strongest emotion I felt today? ";
                        Console.Write(promptText);
                        entryText = Console.ReadLine();
                    }

                    else if (magicNumber == 5)
                    {
                        promptText = "If I had one thing I could do over today, what would it be? ";
                        Console.Write(promptText);
                        entryText = Console.ReadLine();
                    }

                    journal.AddEntry(new Entry(dateText, promptText, entryText));
                    Console.WriteLine("Journal entry added!");
                    break;

                case "2":
                    // Display all entries
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Display all entries
                    journal.DisplayEntries();
                    break;

                case "4":
                    // Display all entries
                    journal.DisplayEntries();
                    break;

                case "5":
                    // Exit the program
                    exit = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}