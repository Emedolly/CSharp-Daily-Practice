namespace Day06;

public class FilterNumbers
{
    public List<int> Filter(List<int> list, Func<int, bool> rule)
    {
        List<int> result = new List<int>();
        foreach (int n in list )
        {
            if (rule(n))
            {
                result.Add(n);
            }
        }
        return result;
    }
}