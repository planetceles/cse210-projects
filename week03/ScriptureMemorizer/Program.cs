using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // I added the following exceeding
        /*
        a library of scriptures
        the program select a random scripture each time it runs
        the program avoids hiding words that already hidden
        */

        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>();

        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture(r2, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        Reference r3 = new Reference("Mosiah", 2, 17);
        Scripture s3 = new Scripture(r3, "When ye are in the service of your fellow beings ye are only in the service of your God");

        scriptures.Add(s1);
        scriptures.Add(s2);
        scriptures.Add(s3);

        int index = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[index];

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program ended!");



    }
}