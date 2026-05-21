using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("Journal Program");

        Journal myJournal = new Journal();

        Entry entry1 = new Entry();

        PromptGenerator prompt = new PromptGenerator();

        // PromptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("What made me smile today?");
        prompt._prompts.Add("What did I learn today?");

        // prompt._prompts.Add("How was your mood today?");
        // string mood = Console.ReadLine();
        // entry._mood = mood;


        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string journalPrompt = prompt.GetRandomPrompt();
                Console.Write("> ");

                string answer = Console.ReadLine();

                // I will ask for the mood to exceed the requirements
                Console.Write("How was your mood today? ");
                string mood = Console.ReadLine();

                // I will use the DateTime to exceed some of the requirements
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = journalPrompt;
                entry._entryText = answer;
                entry._mood = mood;

                // Journal.AddEntry(entry);
                myJournal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
        }

    }
}