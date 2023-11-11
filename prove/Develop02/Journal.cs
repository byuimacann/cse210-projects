using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Xml.XPath;

public class Journal
{
    //A tutor helped me with a few things on this page...the most signficant help from him on this particular page was him helping me get the correct coding for the random prompt in my AddEntry function. 
    
    public List<Entry> _entries = new List<Entry>();
    public List<Entry> _savedEntries = new List<Entry>();


    public void AddEntry()
    { 
        Entry newResponse = new Entry();

        //I used the 'Code Helps' found in the course's 'Develop:Journal Program' assignment instructions to help me code the next 2 lines to get the current date.
        DateTime currentDate = DateTime.Now;
        newResponse._date = currentDate.ToShortDateString();

        Console.Write("Enter Location: ");
        newResponse._location = Console.ReadLine();

        Prompt prompt = new Prompt();
        string randPrompt = prompt.RandomPrompt();
        newResponse._entryPrompt = randPrompt; 
        Console.Write($"{randPrompt}\n> ");
        newResponse._entry = Console.ReadLine();
        Console.WriteLine(); // blank line
        
        _entries.Add(newResponse);
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryInfo();
        }

        foreach (Entry entry in _savedEntries)
        {
            entry.DisplayEntryInfo();
        }
    }
    
    public void SaveJournalEntry()
    {
      //I used the 'Code Helps' found in the course's 'Develop:Journal Program' assignment instructions to help me code this method/function.
      Console.Write("Enter a filename: ");
      string file = Console.ReadLine();
      using (StreamWriter savedFile = new StreamWriter(file))
      {
        foreach (Entry entry in _entries)
        {
        savedFile.WriteLine($"{entry._date}|{entry._location}|{entry._entryPrompt}|{entry._entry}");
        } 
      }
    }

    public void LoadEntriesFromFile()
    {
      //I used the 'Code Helps', and the video about reading and writing to a file, found in the course's 'Develop:Journal Program' assignment instructions, to help me code this method/function.
      Console.Write("Enter a filename: ");
      string fileName = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines(fileName);
        
      foreach (string line in lines)
      {
        Entry savedEntry = new Entry();
        string[] sections = line.Split("|");

        savedEntry._date = sections[0];
        savedEntry._location = sections[1];
        savedEntry._entryPrompt = sections[2];
        savedEntry._entry = sections[3];

        _savedEntries.Add(savedEntry);
      }
    }

}