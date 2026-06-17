using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");

        // I added a level system,
        // when the score increase, the user will gain more level
        // every 1000 points will increase the level by one
        // the current level is displayed with the score

        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            manager.DisplayScore();

            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("\nChoice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;

                case 2:
                    manager.ListGoals();
                    break;

                case 3:
                    manager.RecordEvent();
                    break;

                case 4:
                    manager.SaveGoals();
                    break;

                case 5:
                    manager.LoadGoals();
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}