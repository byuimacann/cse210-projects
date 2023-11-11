public class Prompt
{
    public List<String> _prompts = new List<String>() {"What was the best part of your day?", "Who did you interact with today?", "What are you grateful for today?", "What was your mood like today?", "What was the weather like today?...how did it effect your day?", "What is one thing I would have done differently today?", "What is one thing I learned today?", "Did you have a good day today?"};

    
    public string RandomPrompt()
    {
        //A tutor helped me figure out how to return a random int converted to a string, resulting in the final code below.
        Random rand = new Random();  

        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

}