using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running running = new Running("11 Dec 2023", 45, "Running", 3.2);
        _activities.Add(running);
        

        Cycling cycling = new Cycling("30 Nov 2023", 90, "Cycling", 8.5);
        _activities.Add(cycling);
        

        Swimming swimming = new Swimming("03 Aug 2023", 100, "Swimming", 25);
        _activities.Add(swimming);
        

        foreach (Activity activity in _activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
        }
        
    }
}