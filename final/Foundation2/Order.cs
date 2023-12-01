public class Order
{
    private Customer _customer;
    private List<Product> _cart;
    private double _total;
    private string _packing_label;
    private string _shipping_label;

    public Order(Customer customer, List<Product> cart)
    {
        _customer = customer;
        _cart = cart;
        Calculate_Total();
        Packing_Label();
        Shipping_Label();
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public List<Product> Cart
    {
        get { return _cart; }
        set { _cart = value; }
    }

    public double Total
    {
        get { return _total; }
        set { _total = value; }
    }

    public string Get_Packing_Label()
    {
        return _packing_label;
    }

    public string Get_Shipping_Label()
    {
        return _shipping_label;
    }

    private void Calculate_Total()
    {
        foreach (Product product in _cart)
        {
            _total += product.Total_Price();
        }
        if (!_customer.USA_Based())
        {
            _total += 35.00;
        }
        else
        {
            _total += 5.00;
        }
    }

    private void Packing_Label()
    {
        _packing_label = $"To: {_customer.Name}\n\nProduct Id : Name x Quantity @ Price\n";
        foreach (Product product in _cart)
        {
            _packing_label += $"{product.Id} : {product.Name} x {product.Quantity} @ ${product.Price}\n";
        }
        _packing_label += $"\nTotal: {_total:C}";
    }

    private void Shipping_Label()
    {
        _shipping_label = $"To:\n{_customer.Address.Format()}\n";
    }
}