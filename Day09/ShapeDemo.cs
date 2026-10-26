namespace Day09;
public interface IShape
{ 
    double Area();
}
public class Circle:IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius=radius;
    }
    public double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width=width;
        Height=height;
    }

    public double Area()
    {
        return Width * Height;
    }
}

public static class ShapeDemo
{
    public static void Run()
    {
        Circle c = new Circle(2);
        Rectangle r = new Rectangle(3, 4);
        Console.WriteLine($"Area of the circle is {c.Area()}");
        Console.WriteLine($"Rectangle area is {r.Area()}");
    }
}
public static class ShapeList
{
    public static void Run()
    {
        List<IShape> shapes = new List<IShape>();
        shapes.Add(new Circle(2));
        shapes.Add(new Rectangle(3, 4));
        shapes.Add(new Rectangle(5, 2));
        double total = 0;
        foreach (var shape in shapes)
        {
            double area = shape.Area();
            total = total + area;
        }
        Console.WriteLine($"Total area is {total}");
    }
}

