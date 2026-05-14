using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // using System.Collections.Generic;

        List<int> numbers = new List<int>();
        // int response = 1;
        int numberList = -1;

        // Console.Write("Enter a list of numbers (0 to quit): ");

        

        while (numberList != 0)
        {
            Console.Write("Enter a numbers (0 to quit): ");
            string numList = Console.ReadLine();
            numberList = int.Parse(numList);

            if (numberList != 0)
            {
                numbers.Add(numberList);
            }
            // sum
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // average
            float average = (float)sum / numbers.Count;

            Console.WriteLine($"The average is: {average}");

            // maximum
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }



            // Console.WriteLine($"List is: {numbers.Count}");
            
            
            Console.WriteLine($"The largest is: {max}");

            // Console.Write("You want add more? ");
            // string answer = Console.ReadLine();
            // response = int.Parse(answer);
        }
    }
}