using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Dynamic;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _detailsString;
    private string _goalType;
    

    public void Start()
    {
        int userOption = 0;
        while (userOption != 6)
        {
            Console.WriteLine(); // blank line

            DisplayPlayerInfo();

            Console.WriteLine(); // blank line

            Console.WriteLine("Menu Option:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = int.Parse(Console.ReadLine());
           
            if (userOption == 1)
            {
                CreateGoal();
            }
            else if (userOption == 2)
            {
                ListGoalDetails();
            }
            else if (userOption == 3)
            {
                SaveGoals();
            }
            else if (userOption == 4)
            {
                LoadGoals();
            }
            else if (userOption == 5)
            {
                RecordEvent();
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points"); 
    }

    public void ListGoalNames()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        
        foreach(Goal goal in _goals)
        {   
            
            if (goal.GetIsComplete() == true)
            {
                Console.WriteLine($"[X] {goal.GetDetailsString()}");
            }
            else 
            {
                Console.WriteLine($"[ ] {goal.GetDetailsString()}");
            }
            
        }
    }    


    public void CreateGoal()
    {
        Console.Write("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. CheckList Goal\nWhich type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        
        if (goalType == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the point value of this goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal sG = new SimpleGoal(name, description, points);
            _goals.Add(sG);
        }

        else if (goalType == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the point value of this goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal eG = new EternalGoal(name, description, points);
            _goals.Add(eG);
        }
        
        else if (goalType == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the point value of this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times do you need to complete this goal for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing this goal that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            Goal cG = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(cG);
        }
    }

    public void RecordEvent()
    {
        Console.Write("What is the name of the goal that you completed? ");
        string userInput = Console.ReadLine();
        foreach (Goal goal in _goals)
        {
            if (userInput == goal.GetGoalName())
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
            }
        }

    }
    
    public void SaveGoals()
    {   
        Console.Write("What is the filename for your goals? ");
        string file = Console.ReadLine();
        using (StreamWriter savedgoalFile = new StreamWriter(file))
        {   
            savedgoalFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                savedgoalFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for your goals? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {   
            if (line == lines[0])
            {
                _score = int.Parse(line);     
            }
            else if (line != lines[0])
            {
                string[] goalPart = line.Split(":");
                string goalType = goalPart [0];
                string goalDetails = goalPart[1];
                _goalType = goalType;
                _detailsString = goalDetails;
                CreateGoalFromFile();
            }
            
        } 
           
    }
            
    public void CreateGoalFromFile()
    {   
        string[] parts = _detailsString.Split(",");

       // foreach (string part in parts)
        
        if (_goalType == "SimpleGoal")
        {
            string goalName = parts[0];
            string goalDescription = parts[1];
            string goalPoints = parts[2];
            string goalIsComplete = parts[3];

            string name = goalName;
            string description = goalDescription;
            int points = int.Parse(goalPoints);
            bool complete = bool.Parse(goalIsComplete); //  learned how to covert string bool here: https://code-maze.com/csharp-convert-string-to-bool/
            Goal sG = new SimpleGoal(name, description, points, complete);
            _goals.Add(sG);
            
        }    

        else if (_goalType == "EternalGoal")
        {
            string goalName = parts[0];
            string goalDescription = parts[1];
            string goalPoints = parts[2];
            string goalIsComplete = parts[3];

            string name = goalName;
            string description = goalDescription;
            int points = int.Parse(goalPoints);
            bool complete = bool.Parse(goalIsComplete);
    
            Goal eG = new EternalGoal(name, description, points, complete);
            _goals.Add(eG);
            
        }    
        
        else if (_goalType == "CheckListGoal")
        {
            string goalName = parts[0];
            string goalDescription = parts[1];
            string goalPoints = parts[2];
            string goalIsComplete = parts[3];
            string goalBonus = parts[4];
            string goalTarget = parts[5];
            string goalAmountComplete = parts[6];
            

            string name = goalName;
            string description = goalDescription;
            int points = int.Parse(goalPoints);
            bool complete = bool.Parse(goalIsComplete); 
            int bonus = int.Parse(goalBonus);
            int target = int.Parse(goalTarget);
            int amountComplete = int.Parse(goalAmountComplete);

            Goal cG = new CheckListGoal(name, description, points, complete, bonus, target, amountComplete);
            _goals.Add(cG);
        }
    }

}