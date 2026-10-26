namespace Day08;

public class LinqDistinct
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
        var result = list.Distinct();
        Console.WriteLine(string.Join(",",result));
    }
}