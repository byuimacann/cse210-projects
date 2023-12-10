using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Customer
{
    private string _cName;
    private Address _address;

    public Customer(string cName, Address address)
    {
        _cName = cName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _cName;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddressString();
    
    }

    public string GetCustomerCountry()
    {
        return _address.GetCountry();
    }

}