using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static int AddNumber(int first, int second)
    {
        // first = 5;
        // second = 4;
        int sum = first + second;
        Console.WriteLine(sum);

        return sum;
    }
    static string PromptUserName()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        return fullName;
        // return firstName + lastName;
        
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string answer = Console.ReadLine();
        int favNum = int.Parse(answer);

        return favNum;
    }
    static int SquareNumber(int num)
    {
        int numSquared = num * num;

        return numSquared;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, your favorite number squared is: {squaredNumber}");
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        AddNumber(5, 8);

        int result = AddNumber(3, 2);
        Console.WriteLine(result);

        // PromptUserName();
        string name = PromptUserName();
        Console.WriteLine($"Hello {name}");

        int favNum = PromptUserNumber();
        Console.WriteLine($"{name} your favorite number is: {favNum}");

        int numSquared = SquareNumber(favNum);
        Console.WriteLine($"{name}, your favorite number squared is: {numSquared}");

        DisplayResult(name, numSquared);

        

        // void DisplaMessage()
        // {
        //     console.WriteLine("Welcome to the Program");
        // }

    }
}