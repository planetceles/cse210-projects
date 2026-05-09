using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");

        string score;
        // string letter;

        Console.WriteLine("This Program will determine your letter grade!");
        Console.Write("What is your percentage? ");
        score = Console.ReadLine();

        int x = int.Parse(score);
        int lastDigit = x % 10;

        string letter = "";
        string message = "";
        string letterSign = "";

        if (x >= 90 && x <= 100)
        {
            // Console.WriteLine("A");
            letter = "A";
        }


        else if (x >= 80 && x <=89)
        {
            // Console.WriteLine("B");
            letter = "B";
        }
        // letter = "B";

        else if (x >= 70 && x <=79)
        {
            // Console.WriteLine("C");
            letter = "C";
        }
        // letter = "C";

        else if (x >= 60 && x <=69)
        {
            // Console.WriteLine("D");
            letter = "D";
        }
        // letter = "D";

        else if (x <= 59 )
        {
            // Console.WriteLine("F");
            letter = "F";
        }
        // letter = "F";

        else
        {
            Console.WriteLine("Please enter a percentage equal or less than 100");
        }
        // Console.WriteLine(letter);


        // congratulation message

        if (letter == "A" || letter == "B" || letter == "C")
        {
            message = "Congratulations, you passed the course!";
            // Console.WriteLine("");
        }
        else if (x > 100)
        {
            message = "Waiting";
            // Console.WriteLine("Waiting");
        }
        else
        {
            message = "Please you did not meet the requirements for this course. Consider retaking the course.";
            // Console.WriteLine("");
        }

        // letter sign 

        if (lastDigit >= 7)
        {
            letterSign = "+";
        }
        else if (lastDigit >= 7 && x >= 97)
        {
            letter = "A";
        }
        else if (lastDigit < 3)
        {
            letterSign = "-";
        }

        if (letter == "A" && letterSign == "+")
        {
            letterSign = "";
        }
        else if (letter == "F")
        {
            letterSign = "";
        }

        Console.WriteLine($"{letter}{letterSign}");
        Console.WriteLine(message);
        
    }
}