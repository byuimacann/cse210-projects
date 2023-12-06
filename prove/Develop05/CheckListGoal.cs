public class CheckListGoal : Goal
{
    private int _amountComplete = 0;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public CheckListGoal(string name, string description, int points, bool isComplete, int bonus, int target, int amountComplete) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _isComplete = isComplete;
        _amountComplete = amountComplete;
    }

    public override void RecordEvent()
    {
        _amountComplete += 1;
        if (_amountComplete == _target)
        {
            Console.WriteLine($"[X] {GetDetailsString()}");
            IsComplete();
            Console.WriteLine($"Great job! You have earned {_bonus + _points} points!");
            _points += _bonus;  
        }
        else
        {
            Console.WriteLine($"[ ] {GetDetailsString()}");
            Console.WriteLine($"Great job! You have earned {_points} points!");
            // _points += _points;

        }
    }

    public override bool IsComplete()
    {
       if (_isComplete == false)
        {
            _isComplete = true;
        }
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_description}) -- Currently completed: {_amountComplete}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_name},{_description},{_points},{_isComplete},{_bonus},{_target},{_amountComplete}";
    }
}