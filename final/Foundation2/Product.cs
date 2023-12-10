public class Product
{
    private string _pName;
    private string _productId;
    private double _price;
    private int _qty;

    public Product(string pName, string productId, double price, int qty)
    {
        _pName = pName;
        _productId = productId;
        _price = price;
        _qty = qty;
    }

    public double CalculatePrice()
    {
        return _price *= _qty;
    }

    public string GetProductName()
    {
        return _pName;
    }

    public string GetProductId()
    {
        return _productId;
    }
}