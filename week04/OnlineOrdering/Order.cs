using System;

public class Order
// This class has the following responsibilities:

// Contains a list of products and a customer. Can calculate the total cost of the order.
// Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA.

// If the customer lives in the USA, then the shipping cost is $5.
// If the customer does not live in the USA, then the shipping cost is $35.

// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
{
    private List<Product> _product = new List<Product>();
    private List<Customer> _customer = new List<Customer>();

    public void SetOrder(Product product, Customer customer)
    {
        _product.Add(product);
        _customer.Add(customer);
    }

    public string ShippingLabel()
    {
        string label = "";
        foreach (var customer in _customer)
        {
           label += customer.GetCustomerDetails();
        }
        return label;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in _product)
        {
           label += product.PackingLabel();
        }
        return label;
    }

    private int ShippingCost()
    {
        bool check = false;
        int [] numbers = {5, 35};
        int shippingCost = 0;
        foreach (var customer in _customer)
        {
            if(customer.CheckCountry() == check)
            {
                shippingCost = numbers[1];
            }

            else
            {
                shippingCost = numbers[0];
            }
        }

        return shippingCost;
    }

    public void Total()
    {
        int total = 0;
        foreach (var product in _product)
        {
            total += product.Total();
        }

        int Total = total + ShippingCost();
        
        Console.WriteLine(Total);
    }

}