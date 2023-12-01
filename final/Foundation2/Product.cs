public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private int _id;

    public Product(string name, double price, int quantity, int id)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }   

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public void AddQuantity(int quantity)
    {
        _quantity += quantity;
    }

    public void SubtractQuantity(int quantity)
    {
        _quantity -= quantity;
    }

    public double Total_Price()
    {
        return _price * _quantity;
    }
}