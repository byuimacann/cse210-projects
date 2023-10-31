using System;
using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        
        string letter = "";
        int lastNumber = percentage % 10;
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
            if (lastNumber < 3)
            {
                sign = "-";
            }  
        }
        else if (percentage >= 80)
        {
            letter = "B";
            if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }  
        }
        else if (percentage >= 70)
        {
            letter = "C";
            if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }  
        }
        else if (percentage >= 60)
        {
            letter = "D";
            if (lastNumber >= 7)
            {
                sign = "+";
            }
            else if (lastNumber < 3)
            {
                sign = "-";
            }  
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congrats! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry...you did not pass the class. Better luck next time.");
        }

    }
}