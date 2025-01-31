using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("103 Lince St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice McJohnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT1004", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "MSE2002", 25.99m, 2));

        Address address2 = new Address("496 Manfred St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Thomas Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KBD3003", 49.99m, 1));
        order2.AddProduct(new Product("Monitor", "MON4004", 199.99m, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}\n");
        }
    }
}
/*What is get?
In C#, properties are a safer alternative to public fields. A property typically has getters (get) and setters (set) to control access.
The get; means you can read the value of Name but not modify it.*/