using System.Diagnostics;
using System.Diagnostics.Tracing;

public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; 
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }
    
    public string GetFractionString()
    {   
        //Viewing the sample solution helped me fix my code in this section.
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        // Used sample solution to help get correct output using (double) in front of both member variables.
        return (double)_top / (double)_bottom;
    }
    
}