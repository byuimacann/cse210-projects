public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, string activityType, double distance) : base(date, minutes, activityType)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 1);
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance / GetMinutes() * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / _distance, 1);
    }

}


