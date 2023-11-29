using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square squ = new Square("blue", 6);
        Console.WriteLine(squ.GetColor());
        Console.WriteLine(squ.GetArea());

        Rectangle rec = new Rectangle("pink", 5, 2);
        Console.WriteLine(rec.GetColor());
        Console.WriteLine(rec.GetArea());

        Circle cir = new Circle("yellow", 4);
        Console.WriteLine(cir.GetColor());
        Console.WriteLine(cir.GetArea());

        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(squ); 
        shapes.Add(rec);
        shapes.Add(cir);
        
        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The color of the shape is {shape.GetColor()}, and the area is {shape.GetArea()}");
        } 

    }
}