public class Swimming : Activity
{
    private double _laps;

    public double Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

     public override double Distance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double Speed()
    {
        double speed = (Distance() / base.Length) * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = base.Length / Distance();
        return pace;
    }

    public override string Summary()
    {
        return $"{base.Date} Swimming ({base.Length} min)- Distance: {Distance():F2} km, Speed: {Speed():F2} kph, Pace: {Pace():F2} min/km";
    }
}