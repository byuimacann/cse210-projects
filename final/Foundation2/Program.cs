using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    
        Order order1 = new Order(new Customer("Janice Farmer", new Address("1857 N Sego Lilly Dr", "Saratoga Springs", "Utah", "USA")));
        Product product1 = new Product("Mattress", "MS64592", 499.95, 1);
        order1.GetProductList().Add(product1);
        Product product2 = new Product("Santa SnowGlobe", "SS8942", 39.99, 5);
        order1.GetProductList().Add(product2);
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.CalculateOrderTotal();

        Order order2 = new Order(new Customer("Nicholas Saint", new Address("30199 North Dr", "Victoria", "British Columbia", "Canada")));
        Product product3 = new Product("Christmas Gnome", "CG2564", 19.95, 3);
        order2.GetProductList().Add(product3);
        Product product4 = new Product("Snowboard", "RD56488", 229.99, 2);
        order2.GetProductList().Add(product4);
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        order2.CalculateOrderTotal();
    }
}