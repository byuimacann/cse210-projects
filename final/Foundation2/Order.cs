using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shippingCost = 0;
    private double _orderTotal = 0;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProductList()
    {
        return _products;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {    
            Console.WriteLine($"Product: {product.GetProductName()} — {product.GetProductId()}");
        }
        
    }

    public void DisplayShippingLabel()
    {   
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress());  
    }

    public void CalculateOrderTotal()
    {
        if (_customer.GetCustomerCountry() != "USA")
        {   
            _shippingCost = 35.00; 
            foreach(Product product in _products)
            {
                _orderTotal += product.CalculatePrice();
            }
            _orderTotal += _shippingCost;
            Console.WriteLine($"Order Total: ${_orderTotal}");
        }

        else
        {   
            _shippingCost = 5.00;
            foreach(Product product in _products)
            {
                _orderTotal += product.CalculatePrice();
            }
            _orderTotal += _shippingCost;
            Console.WriteLine($"Order Total: ${_orderTotal}");
        }
        Console.WriteLine(); // blank line
    }

}