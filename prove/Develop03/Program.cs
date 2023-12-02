using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (userInput != "quit")
        {   
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine(); // blank line
                Console.WriteLine("Press enter to continue or type 'quit' to end.");
                userInput = Console.ReadLine();
            }

            Console.Clear(); 

            scripture.HideRandWords(3);                             
        }


        


    }
}