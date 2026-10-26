namespace Day03;

public class Box<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        this.Value = value;
    }

    public void show()
    {
        Console.WriteLine($"Box holds value of {Value}");
    }
}