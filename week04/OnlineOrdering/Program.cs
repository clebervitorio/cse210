using System;

class Program
{
    static void Main()
    {
        // first order - customer from Brazil BRA
        Address address1 = new Address("Rua Venezuela, 22", "Cariacica", "Espirito Santo", "Brazil");
        Customer customer1 = new Customer("Max Mauro Vitorio", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP3276", 1200m, 3));
        order1.AddProduct(new Product("Keyboard", "KB7549", 40m, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: R$ " + String.Format("{0:N2}",(order1.GetTotalPrice()))); // using R$(Real) as symbol and converted the dollar to Real

        Console.WriteLine();

 // second order - customer from the USA
        Address address2 = new Address("456 Main St", "Los Angeles", "California", "USA");
        Customer customer2 = new Customer("Jason Rice", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KB7549", 40m, 1));
        order2.AddProduct(new Product("Monitor", "MN7289", 200m, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: " + string.Format("{0:C}",order2.GetTotalPrice())); 
    }
}