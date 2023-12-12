using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
    
        Lecture event1 = new Lecture("Lecture", "'Scientific Discoveries of Our Time'", "Come hear from the top medical research scientist about new scientific discoveries in the field of medicine.", "December 18th, 2023", "6:00 pm", new Address("20561 Gateway Dr.", "Phoenix", "AZ", "85004"), "Dr. James McGrath", 200);
        event1.DisplayStandardDetails();
        event1.DisplayFullDetails();
        event1.DisplayShortDescription();


        Reception event2 = new Reception("Reception", "'Meet Senator Michael Graham'", "Come show your support and celebrate with us as we welcome Senator Michael Graham into office.", "January 10th, 2024", "7:00 pm", new Address("17760 N Capital Way", "Lakeland", "Michigan", "35298"), "admin@windsorhouse.com");
        event2.DisplayStandardDetails();
        event2.DisplayFullDetails();
        event2.DisplayShortDescription();


        OutdoorGathering event3 = new OutdoorGathering("Outdoor Gathering", "'Under the Night Sky Gala'", "Enjoy the cool summer night and the beautiful stars at our annual fundraiser gala.", "July 15th, 2024", "8:30 pm", new Address("6958 Sparkle Point", "Los Angeles", "CA", "97562"), "clear skies, 0% change of rain, wind 2 mph");
        event3.DisplayStandardDetails();
        event3.DisplayFullDetails();
        event3.DisplayShortDescription();

    }
}