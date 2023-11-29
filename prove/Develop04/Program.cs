using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Really the only extra thing I added in excess of the core requirements, was a user prompt to enter the time the user wanted to breathe in and out for in the Breathing Activity. I am not sure if this counts for creativity/exceeding requirements or not though. If not, that's fine.

        int userSelection = 0;
        
        while (userSelection != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu options: ");
            userSelection = int.Parse(Console.ReadLine());
            Console.Clear();
 
            if(userSelection == 1)
            {    
               BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."); 
               breathingActivity.Run();
            }

            else if (userSelection == 2)
            {
               ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."); 

               reflectingActivity.Run();
            }

            else if (userSelection == 3)
            {
               ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

               listingActivity.Run(); 
            }
        }

        Console.WriteLine("Goodbye.");
    }
}