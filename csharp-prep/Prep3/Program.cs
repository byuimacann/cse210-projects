using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine(); 
        // int magicNumber = int.Parse(userInput);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}