using System;

class Program
{
    static void Main(string[] args)
    {
        //Viewing the sample solution helped me realize why my output was not showing up. I needed to call the method in the Console.WriteLine() so it would display on the screen.

        Fraction f1 = new Fraction();
        // f1.SetTopNumber(1);
        // f1.SetBottomNumber(1);
        // Console.WriteLine($"{f1.GetTopNumber()}/{f1.GetBottomNumber()}");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        // f2.SetTopNumber(6);
        // f2.SetBottomNumber(1);
        // Console.WriteLine($"{f2.GetTopNumber()}/{f2.GetBottomNumber()}");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        // f3.SetTopNumber(6);
        // f3.SetBottomNumber(7);
        // Console.WriteLine($"{f3.GetTopNumber()}/{f3.GetBottomNumber()}");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}