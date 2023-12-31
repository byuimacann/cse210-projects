public class OutdoorGathering : Event
{
    private string _weather;


    public OutdoorGathering(string eventType, string eventTitle, string description, string date, string time, Address address, string weather) : base(eventType, eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"{GetEventType()}\nWeather for {GetDate()} - {_weather}");
        DisplayStandardDetails(); 
    }
}