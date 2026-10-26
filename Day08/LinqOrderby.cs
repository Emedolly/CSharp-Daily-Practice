namespace Day08;

public class LinqOrderby
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
        var result = list.OrderByDescending(n => n);
        Console.WriteLine(string.Join(",", result));
    }
}