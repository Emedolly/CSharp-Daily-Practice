namespace Day08;

public class LinqCompare
{
    public static void Run()
    {
        List<int> numbers = new List<int>() { 4, 9, 2, 7 };
        var secondLargest = numbers.Distinct().OrderByDescending(n => n).Skip(1).First();
        Console.WriteLine(secondLargest);
    }
}