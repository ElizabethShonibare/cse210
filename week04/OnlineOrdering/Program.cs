using System;

public class Program
{
    public static void Main(string[] args)
    {
        // ===== Order 1 =====
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("Queen Elizabeth", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "L109", 900.00, 1));
        order1.AddProduct(new Product("Mouse", "M011", 25.00, 2));
        order1.AddProduct(new Product("Keyboard", "K005", 50.00, 1));

        // ===== Order 2 =====
        Address address2 = new Address(
            "456 King Street",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Promise George", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "M010", 250.00, 2));
        order2.AddProduct(new Product("Webcam", "W001", 75.00, 1));

        // ===== Display Order 1 =====
        Console.WriteLine("ORDER 1");
        Console.WriteLine("------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine("\n========================\n");

        // ===== Display Order 2 =====
        Console.WriteLine("ORDER 2");
        Console.WriteLine("------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}