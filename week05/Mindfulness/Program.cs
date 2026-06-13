using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");

        // Exceeding requirements:
        // This program tracks how many times each activity
        // has been completed during the current session.
        // the reflection prompts and Listing prompts
        // are not repeated until all available items have
        // been used.

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine($"Breathing Sessions : {breathingCount}");
            Console.WriteLine($"Reflection Sessions: {reflectionCount}");
            Console.WriteLine($"Listing Sessions   : {listingCount}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;

                case "2":
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.Run();
                    reflectionCount++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}