using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an address
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");

        // Create a customer
        Customer customer = new Customer("John Doe", address);

        // Create some products
        Product product1 = new Product("Widget", 101, 10.00m, 3);
        Product product2 = new Product("Gadget", 102, 20.00m, 2);

        // Create an order and add products
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display packing label
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        // Display shipping label
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        // Display total cost
        Console.WriteLine($"\nTotal Cost: ${order.CalculateTotalCost():F2}");
    }
}
