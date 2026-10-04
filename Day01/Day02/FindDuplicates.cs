namespace Day02;

public class FindDuplicates
{
    public void Run()
    {
        List<int> numbers = new List<int>() { 1, 2, 2, 3, 3 };
        List<int> seen = new List<int>();
        List<int> duplicates = new List<int>();
        foreach (var item in numbers)
        {
            if (seen.Contains(item))
            {
                if (!duplicates.Contains(item))
                {
                    duplicates.Add(item);
                }
            }
            else
            {
                seen.Add(item);
            }
        }
        Console.WriteLine(string.Join(",", duplicates));
    }
}