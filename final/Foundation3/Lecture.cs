public class Lecture : Event
{
    private string _speaker;
    private int _capacityLimit;

    public Lecture(string eventType, string eventTitle, string description, string date, string time, Address address, string speaker, int capacityLimit) : base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacityLimit = capacityLimit;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"{GetEventType()}\nSpeaker - {_speaker} | Capacity - {_capacityLimit}");
        DisplayStandardDetails();
    }

}