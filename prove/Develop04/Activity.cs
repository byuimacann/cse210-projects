public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n\n{_activityDescription}\n");
        Console.Write("How long, in seconds, would you like your session to last? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.WriteLine(); // blank line
        Console.Write("Prepare to begin");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {   
        Console.WriteLine(); // blank line
        Console.Write($"Great job!");
        ShowSpinner(3);
        Console.Write($"You have completed the {_activityName} that lasted {_activityDuration} seconds");
        ShowSpinner(5);
        Console.Clear();
        
    }

    //I used the Code Helps and video in the assignment instructions to help me complete the 2 methods shown below.
    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

}