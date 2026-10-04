namespace Day02;

public class ListBasic
{
    public void Run()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}