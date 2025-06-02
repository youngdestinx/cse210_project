using System;

public class Product
// This class has the following responsibilities:
//
// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity.
// (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
{
    private string _name;
    private double _productId;
    private int _price;
    private int _quantity;

    public void SetProduct(string name, double productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int Total()
    {
       int total = _price * _quantity;
       return total;
    }

    public string PackingLabel()
    {
        return ($"{_name}; {_productId}"); 
    }
}