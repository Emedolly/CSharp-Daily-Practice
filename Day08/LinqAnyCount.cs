namespace Day08;

public class LinqAnyCount
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
        var result = list.Any(n => n > 8);
        Console.WriteLine(result);
        var resultCount = list.Count(n=>n % 2 == 0);
        Console.WriteLine(resultCount);
    }
}