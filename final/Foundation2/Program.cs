using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("Aaron>1234 Main St>Caldwell,ID 83607>USA");
        Address address2 = new Address("Bob>123 Main St>Toronto, ON M1A 1A1>Canada");
        Customer customer1 = new Customer("Aaron", address1);
        Customer customer2 = new Customer("Bob", address2);
        Product product1 = new Product("Widget", 10.00, 5, 1);
        Product product2 = new Product("Gadget", 15.00, 7, 2);
        Product product3 = new Product("Gizmo", 20.00, 9, 3);
        Product product4 = new Product("Thingamabob", 25.00, 11, 4);
        Product product5 = new Product("Doohickey", 30.00, 13, 5);
        Product product6 = new Product("Whatchamacallit", 35.00, 15, 6);
        Order order1 = new Order(customer1, new System.Collections.Generic.List<Product> { product1, product2, product3 });
        Order order2 = new Order(customer2, new System.Collections.Generic.List<Product> { product4, product5, product6 });

        Console.WriteLine(order1.Get_Packing_Label());
        Console.WriteLine(order1.Get_Shipping_Label());
        Console.WriteLine($"Total: ${order1.Total}");
        Console.WriteLine();
        Console.WriteLine(order2.Get_Packing_Label());
        Console.WriteLine(order2.Get_Shipping_Label());
        Console.WriteLine($"Total: ${order2.Total}");
    }
}