using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("43 Main St", "Danbury", "CT", "USA");
        Address address2 = new Address("463 Main St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Joseph Gains", address1);
        Customer customer2 = new Customer("Ellen Holdings", address2);

        // Create products
        Product product1 = new Product("Laptop", "E22", 999.99m, 1);
        Product product2 = new Product("Mouse", "B4", 19.99m, 2);
        Product product3 = new Product("Keyboard", "J18", 29.99m, 1);
        Product product4 = new Product("Monitor", "R38", 99.99m, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display order details
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
