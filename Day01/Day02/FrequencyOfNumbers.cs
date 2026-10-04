namespace Day02;

public class FrequencyOfNumbers
{
    public void Run()
    {
        List<int> list = new List<int>() { 1, 2, 2, 3, 3, };
        Dictionary<int, int> frerquency = new Dictionary<int, int>();
        foreach (var item in list)
        {
            if (frerquency.ContainsKey(item))
            {
                frerquency[item]++;
            }
            else
            {
                frerquency[item] = 1;
            }
        }
        Console.WriteLine(string.Join(",", frerquency));
    }
}