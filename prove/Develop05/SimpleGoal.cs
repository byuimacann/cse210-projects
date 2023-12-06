using System.IO.Compression;

public class SimpleGoal : Goal
{
   
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    } 

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"[X] {GetDetailsString()}");
        IsComplete();
        Console.WriteLine($"Great job! You have earned {_points} points!");   
    }

    public override bool IsComplete()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
        }
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}