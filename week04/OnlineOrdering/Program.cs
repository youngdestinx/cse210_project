using System;

class Program
{
    static void Main(string[] args)
    {
        // Once you have created these classes, write a program that creates at least two orders with a 2-3 product
        // each. Call the methods to get the packing label, the shipping label, and the total price of the order,
        // and display the results of these methods.
        Address deborah = new Address();
        deborah.SetAddress("twinade", "ilogbo", "lagos", "Nigeria");
        
        Customer vivian = new Customer();
        vivian.SetCustomer("deborah", deborah);

        Product iphone = new Product();
        iphone.SetProduct("phone", 1011, 3, 5);

        Product tv = new Product();
        tv.SetProduct("tv", 1001, 5, 10);


        Order order1 = new Order();
        order1.SetOrder(iphone, vivian);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        order1.Total();
        Console.WriteLine();

        Order order2 = new Order();
        order2.SetOrder(tv, vivian);
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        order2.Total();

    }
}