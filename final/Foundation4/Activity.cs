public abstract class Activity
{
    private string _date;
    private double _length;

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract string Summary();

    public virtual double Distance()
    {
        return 0.0;
    }

    public virtual double Speed()
    {
        return 0.0;
    }

    public virtual double Pace()
    {
        return 0.0;
    }
}