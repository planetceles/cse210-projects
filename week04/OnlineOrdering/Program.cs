using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("43 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("James Cobber", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 200, 1));
        order1.AddProduct(new Product("Mouse", "P101", 50, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 100, 1));

        Address address2 = new Address("456 King Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Mary Anne", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P200", 800, 1));
        order2.AddProduct(new Product("Charger", "P201", 25, 3));

        Console.WriteLine("Order 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}