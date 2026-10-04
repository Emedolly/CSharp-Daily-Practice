namespace Day02;

public class ListSumAverage
{
    public void Run()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        Console.WriteLine(sum);
    }
}