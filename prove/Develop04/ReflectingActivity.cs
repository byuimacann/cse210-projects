public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    private List<string> _questions = new List<string>() {"Why was this experience meaningful to you? ", "Have you ever done anything like this before? ", "How did you get started? ", "How did you feel when it was complete? ", "What made this time different than other times when you were not as successful? ", "What is your favorite thing about this experience? ", "What could you learn from this experience that applies to other situations? ", "What did you learn about yourself through this experience? ", "How can you keep this experience in mind in the future? "};


    public ReflectingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Think about the following prompt:");
        GetRandomPrompt();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        
        while (endTime > startTime)
        {
            if (endTime > startTime) 
            {   
                GetRandomQuestion();
                DisplayQuestions();
                ShowSpinner(5);
                Console.WriteLine(); //blank line

                DateTime currentTime = DateTime.Now; 
                startTime = currentTime;
            }
        }

        DisplayEndingMessage(); 
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        string randPrompt = _prompts[promptIndex]; 
        return randPrompt;
    }

    private string GetRandomQuestion()
    {   
        Random rand = new Random();
        int questionIndex = rand.Next(_prompts.Count);
        string randQuestion = _questions[questionIndex];
        return randQuestion;
    }

    private void DisplayPrompt()
    {   
        Console.WriteLine($"\n---{GetRandomPrompt()}---\n");
    }

    private void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}