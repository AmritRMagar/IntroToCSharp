using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived classes
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        Shape genericShape = new Shape();
        Shape circle = new Circle();
        Shape square = new Square();

        genericShape.Draw();
        circle.Draw();
        square.Draw();
    }
}
