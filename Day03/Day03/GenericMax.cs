namespace Day03;

public class GenericMax
{
    public T Max<T>(List<T> items) where T : IComparable<T>
    {
        T max = items[0];
        foreach (T item in items)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }
}