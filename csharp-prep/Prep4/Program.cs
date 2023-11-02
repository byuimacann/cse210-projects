using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        double sum = 0;
        int number = -1;
        double avg = 0;
       
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach(int integer in numbers)
        {
            sum += integer;
            avg = sum / numbers.Count;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        
        int maxNum = numbers.AsQueryable().Max();
        Console.WriteLine($"The largest number is: {maxNum}");
    }
}