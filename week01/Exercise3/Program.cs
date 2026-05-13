using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("Welcome to Guess My Number!");

        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Console.WriteLine("Enter a number from 1 to 100 to guess");

            Random guessNumberGenerator = new Random();
            int number = guessNumberGenerator.Next(1, 100);

            // Console.Write("What is the magic number? ");
            // responseOne = Console.ReadLine();
            // int number = int.Parse(responseOne);

            int guess = 0;
            int guessCount = 0;

            // string response = "yes";
            // int number;
            // int number = 1;
            // while (number == 1)
            while (guess != number)
            {
                string responseTwo;
                string message = "";

                Console.Write("What is your guess? ");
                responseTwo = Console.ReadLine();

                guess = int.Parse(responseTwo);

                guessCount++;

                if (number > guess)
                {
                    message = "Please guess higher";
                }
                else if (number < guess)
                {
                    message = "Please guess lower";
                }
                else
                {
                    message = "You guessed the number!";
                    Console.WriteLine($"It took you {guessCount} guesses");
                }

                Console.WriteLine(message);



            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }
        

        // string responseOne;

        



        // string response = "yes";
        // Random randomGenerator = new Random();
        // int numberGen = randomGenerator.Next(1, 11);
        // Console.WriteLine(numberGen);
        // int response = numberGen;
        // string response = "yes";

        // while (response == numberGen)
        // {
        // int total = 0;

        // Console.Write("Enter a number: ");
        // int num = int.Parse(Console.ReadLine());

        // Console.Write("Enter an other number: ");
        // int number = int.Parse(Console.ReadLine());

        // if (num > number)
        // {
        //     total = num - number;
        //     Console.WriteLine($"The difference is: {total}");
        // }
        // else if (num < number)
        // {
        //     total = num + number;
        //     Console.WriteLine($"The total is: {total}");
        // }
        // else
        // {
        //     total = num / number;
        //     Console.WriteLine($"The division is: {total}");
        // }

        // int total = num + number;

        // Console.WriteLine($"The total is: {total}");

        // Console.Write("Do you want to continue? ");
        // Console.Write("Guess a number to continue: ");
        // string userResponse = Console.ReadLine();
        // response = int.Parse(userResponse);

        // }




    }
}