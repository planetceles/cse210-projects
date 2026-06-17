using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

         Square square = new Square("Red", 5);

        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");

        Console.WriteLine();

         List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Green", 5, 3));
        shapes.Add(new Circle("Yellow", 2.5));

         foreach (Shape shape in shapes)
        {
            Console.WriteLine(
                $"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}