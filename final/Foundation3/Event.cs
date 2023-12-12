using System.ComponentModel;
using System.Dynamic;

public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    public Event(string eventType, string eventTitle, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventType()
    {
        return _eventType;
    }
    public string GetDate()
    {
        return _date;
    }


    public void DisplayStandardDetails()
    {   
        Console.WriteLine($"{_eventTitle}\n{_description}\n{_date} | {_time}\n{_address.GetAddress()}");
        Console.WriteLine(); // blank line;
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_eventType}: {_eventTitle} | {_date}");
        Console.WriteLine(); // blank line;
        Console.WriteLine("------------------------------------");
        Console.WriteLine(); // blank line;
         
    }
}