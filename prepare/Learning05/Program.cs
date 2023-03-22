using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(5, "red"));
        shapes.Add(new Circle(5, "blue"));
        shapes.Add(new Rectangle(5, 10, "green"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}