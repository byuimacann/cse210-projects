public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, string activityType, double speed) : base(date, minutes, activityType)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * GetMinutes() / 60, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / GetDistance(), 1);
    }

}