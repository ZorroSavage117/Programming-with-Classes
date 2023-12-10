public class Running : Activity
{
    private double _distance;

    public override double Distance()
    {
        return _distance;
    }

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double Speed()
    {
        double speed = (_distance / base.Length) * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = base.Length / _distance;
        return pace;
    }

    public override string Summary()
    {
        return $"{base.Date} Running ({base.Length} min)- Distance: {Distance():F2} km, Speed: {Speed():F2} kph, Pace: {Pace():F2} min/km";
    }
}