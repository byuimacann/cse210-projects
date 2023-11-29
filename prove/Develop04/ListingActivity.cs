using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _itemCount = 0;
    private List<string> _prompts = new List<string>() {"Who are people that you appreciate? ", "What are personal strengths of yours? ", "Who are people that you have helped this week? ", "When have you felt the Holy Ghost this month? ", "Who are some of your personal heroes? "};

    
    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine(); // blank line
        GetListFromUser();
        Console.WriteLine($"You listed {_itemCount} items!");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        int listingPromptIndex = rand.Next(_prompts.Count);
        string randPrompt = _prompts[listingPromptIndex];
        Console.Write($"{randPrompt}...");
    }

    private List<string> GetListFromUser()
    {   
        Console.WriteLine("Keep listing your items.");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        
        List<string> userList = new List<string>();
        
        while(endTime > startTime) 
        {   
            if (endTime > startTime)
            {    
                Console.Write("> ");
                string userItem = Console.ReadLine();
                userList.Add(userItem);
                _itemCount = _itemCount + 1; 

                DateTime currentTime = DateTime.Now; 
                startTime = currentTime;   
            }    
        } 
        return userList; 
    }
}