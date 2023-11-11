using System;
using System.Reflection.Metadata.Ecma335;
// ***For the creativity portion of this assignment, I added a field for the user to enter their location for wherever they are writing their journal entry. The program saves the location that the user inputs along with the date, prompt, and response***
class Program
{
    static void Main(string[] args)
    {   
        //A tutor helped to make sure I setup this program correctly and helped me figure out an issue and helped me think through my coding and gave helps and tips along the way.

        Journal journal = new Journal();
        string userInput = "";
        while (userInput != "5")
        {
            Console.Write("Choose a menu option below (1-5):\n1. Add New Entry\n2. Display All Journal Entries\n3. Save Entry\n4. Load Entries from File\n5. Quit\n> ");
            userInput = Console.ReadLine();
            Console.WriteLine(); // blank line

            if (userInput == "1")
            {
                journal.AddEntry();  
            }
            else if (userInput == "2")
            {
                journal.DisplayJournalEntries();
            }
            else if (userInput == "3")
            {
                journal.SaveJournalEntry();
            }
            else if (userInput == "4")
            {
                journal.LoadEntriesFromFile();
            }
        }
    }
}