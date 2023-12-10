public class Cycling : Activity
{
    private double _speed;

    public override double Speed()
    {
        return _speed;
    }

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        double distance = base.Length * (_speed / 60);
        return distance;
    }

    public override double Pace()
    {
        double pace = (60 / _speed) / base.Length;
        return pace;
    }

    public override string Summary()
    {
        return $"{base.Date} Cycling ({base.Length} min)- Distance {Distance():F2}, Speed: {Speed():F2} kph, Pace: {Pace():F2} min/km";
    }
}