using System;

public class Customer
// This class has the following responsibilities:

// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not.
// (Hint this should call a method on the address to find this.)
{
    private string _name;
    private Address _address = new Address();

    public void SetCustomer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CheckCountry()
    {
        return _address.CheckCountry();
    }

    public string GetCustomerDetails()
    {
        return $"{_name} \n{_address.GetAddress()}";
    }
}