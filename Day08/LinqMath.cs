namespace Day08;

public class LinqMath
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
        var sum = list.Sum();
        Console.WriteLine(sum);
        var average = list.Average();
        Console.WriteLine(average);
        var max = list.Max();
        Console.WriteLine(max);
        var min = list.Min();
        Console.WriteLine(min);
    }
}