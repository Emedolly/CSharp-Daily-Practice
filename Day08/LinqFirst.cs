namespace Day08;

public class LinqFirst
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
       // var result = list.First(n => n > 100); //since there is no element present here it will throw exception
        var result = list.FirstOrDefault(n => n > 100); //eventhough number is not present it will give 0 for int and null for objects
        Console.WriteLine(result);
    }
}