namespace Day08;

public static class LinqSelect
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
        var result = list.Select(n => n * n).ToList();
        Console.WriteLine(string.Join(",", result));
    }
}