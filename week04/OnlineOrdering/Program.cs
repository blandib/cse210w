using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Order 1 - USA
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "N001", 3.5, 4));
        order1.AddProduct(new Product("Pen", "P002", 1.2, 10));

        // Order 2 - International
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Sketchbook", "S003", 7.0, 2));
        order2.AddProduct(new Product("Marker", "M004", 2.5, 5));
        order2.AddProduct(new Product("Eraser", "E005", 0.99, 3));

        // Display Results
        List<Order> orders = new List<Order> { order1, order2 };
        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"\n--- Order {i + 1} ---");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine($"Total Price: ${orders[i].GetTotalPrice():0.00}");
        }
    }
    }
