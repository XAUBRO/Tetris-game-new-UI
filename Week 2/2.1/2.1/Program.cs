using System;

public class Shape
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public virtual double CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Math.Pow(Side, 2);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 'circle' or 'square':");
        string shapeType = Console.ReadLine().ToLower();

        Shape shape;
        if (shapeType == "circle")
        {
            Console.WriteLine("Enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());

            shape = new Circle { Radius = radius };
        }
        else if (shapeType == "square")
        {
            Console.WriteLine("Enter the side length:");
            double side = Convert.ToDouble(Console.ReadLine());

            shape = new Square { Side = side };
        }
        else
        {
            Console.WriteLine("Invalid shape type.");
            return;
        }

        Console.WriteLine($"Area of {shape.Name} is {shape.CalculateArea()}");
    }
}
