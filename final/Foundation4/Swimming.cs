public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, string activityType, double laps) : base(date, minutes, activityType)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62, 2); 
        // portion of code on this webpage, https://www.geeksforgeeks.org/c-sharp-data-types/?ref=shm, helped me learn how to limit decimal places to a certain number using the Math.Round library function.
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / GetMinutes() * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetMinutes() / GetDistance(), 2);
    }

}