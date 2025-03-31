using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Scenario: produce packing labels, shipping labels, and compute final prices for billing.
        // The program contains classes for Product, Customer, Address, and Order.

        // Create an address instance
        // first order - customer from Brazil BRA
        Address address1 = new Address("Rua Venezuela 22", "Cariacica", "Espirito Santo", "BRA");

        // Create a customer instance using the address
        Customer customer1 = new Customer("Max Mauro Vitorio", address1);

        // Create product instances with name, ID, price, and quantity
        Product product1 = new Product("Laptop", 101, 1200.99, 1);
        Product product2 = new Product("Keyboard", 102, 25.50, 2);
        
        // Create an order for the customer
        Order order1 = new Order(customer1);
        
        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Print packing label
        Console.WriteLine(order1.GetPackingLabel());
        
        // Print shipping label
        Console.WriteLine(order1.GetShippingLabel());
        
        // Print total cost of the order, formatted to two decimal places
        Console.WriteLine($"Total Cost: R${(order1.GetTotalCost()*6):F2}");

        Console.WriteLine("---------------------------------------");


        // Create an address instance
        // first order - customer from Brazil USA
        Address address2 = new Address("123 Main St", "Murray", "SLC", "USA");

        // Create a customer instance using the address
        Customer customer2 = new Customer("Jason Rice", address2);

        // Create product instances with name, ID, price, and quantity
        Product product3 = new Product("Laptop", 101, 1200.99, 2);
        Product product4 = new Product("Keyboard", 102, 25.50, 5);
        
        // Create an order for the customer
        Order order2 = new Order(customer2);
        
        // Add products to the order
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Print packing label
        Console.WriteLine(order2.GetPackingLabel());
        
        // Print shipping label
        Console.WriteLine(order2.GetShippingLabel());
        
        // Print total cost of the order, formatted to two decimal places
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");

        Console.WriteLine("---------------------------------------");



    }
}