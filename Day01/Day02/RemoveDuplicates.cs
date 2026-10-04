namespace Day02;

public class RemoveDuplicates
{
    public void Run()
    {
        List<int> list = new List<int> { 1, 2, 2, 3, 3 };
        List<int> result = new List<int>();

        foreach (var item in list)
        {
            if (!result.Contains(item))
            {
                result.Add(item);
            }
        }

        Console.WriteLine(string.Join(",", result));
        ;
    }
}