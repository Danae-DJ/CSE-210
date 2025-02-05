using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("23 Carnaval st.", "Missuri", "MS", "USA");
        Customer customer1 = new Customer("Monica Roma", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Tablet", "Tlb12304", 999.99m, 1));
        order1.AddProduct(new Product("Memory USB", "MESU15402", 25.99m, 2));

        Address address2 = new Address("012 Karaoke St", "Ilinois", "IL", "USA");
        Customer customer2 = new Customer("Federik Jean", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mouse", "MuSE3295", 49.99m, 1));
        order2.AddProduct(new Product("Laptop", "LA1504p", 199.99m, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F3}\n");
            Console.WriteLine("\n");
        }
    }
}//Changes information