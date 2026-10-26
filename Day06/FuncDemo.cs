namespace Day06;

public class FuncDemo
{
    public Func<int, int, int> add = (a, b) => a + b;
    public Func<int, int, int> multiply = (a, b) => a * b;

    public int addMethod(int a, int b)
    {
        return a + b;
    }
}