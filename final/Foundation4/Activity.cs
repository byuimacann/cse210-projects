public class Activity
{
    private string _date;
    private int _minutes;
    private string _activityType;

    public Activity(string date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {_activityType} ({_minutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}