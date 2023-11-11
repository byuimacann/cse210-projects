using System.Configuration.Assemblies;
using System.IO.Compression;

public class Entry
{
    public string _date;
    public string _location;
    public string _entry;
    public string _entryPrompt;
    

    public void DisplayEntryInfo()
    {
        Console.WriteLine($"Date: {_date} Location: {_location}");
        Console.WriteLine($"Prompt: {_entryPrompt}");
        Console.WriteLine(_entry); 
        Console.WriteLine(); // blank space
    }
    
}