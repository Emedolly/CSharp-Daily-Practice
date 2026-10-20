namespace Day06;

public static class ListExtensions
{
    public static void print<T>(this List<T> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }
}