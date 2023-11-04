using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!"); 
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int integer = number * number;
            return integer;
        }
 
        static void DisplayResult(string userName, int integer)
        {
            Console.WriteLine($"{userName}, the square of your number is {integer}");
        }
        
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int squared = SquareNumber(favNumber);
        DisplayResult(name, squared);
    }
}