namespace Day03;

public class GenericPrint
{
    public void PrintAll<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}