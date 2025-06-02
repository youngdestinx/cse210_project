using System;

public class Address
// This class has the following responsibilities:
//
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string of all of its fields together in one string
// (with newline characters where appropriate)
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public void SetAddress(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CheckCountry()
    {        
        if (_country == "USA")
        {
            return true;
        }

        else 
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}\n{_state}\n{_country}";
    }
}