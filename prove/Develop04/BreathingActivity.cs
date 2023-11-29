public class BreathingActivity : Activity
{
    private int _breathDuration;

    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    { 
        DisplayStartingMessage();
        Console.Clear();
               
        Console.Write("How many seconds do you want to breathe in and out for? ");
        _breathDuration = int. Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("Get ready...");
        ShowCountDown(5);
        Console.WriteLine(); // blank line
        Console.WriteLine(); // blank line

        //Video and Code Helps in assignment helped me with some of the DateTime portions of the program. 
        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        
        while(endTime > startTime) 
        {   
            if (endTime > startTime)
            {
                Console.Write("Breathe in...");
                ShowCountDown(_breathDuration);
                Console.WriteLine(); // blank line

                Console.Write("Now breathe out...");
                ShowCountDown(_breathDuration);
                Console.WriteLine(); // blank line
                Console.WriteLine(); // blank line

                DateTime currentTime = DateTime.Now; //Got the idea to include variable with new DateTime occurrence, inside the loop, from a snippet of code at this web address: https://stackoverflow.com/questions/5945533/how-to-execute-the-loop-for-specific-time
                startTime = currentTime;
            }
        }

        DisplayEndingMessage();
        
    }


}