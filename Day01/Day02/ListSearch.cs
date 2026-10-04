namespace Day02;

public class ListSearch
{
    public void Run(int number)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool found = false;
        if (list.Contains(number))
        {
            found = true;
        }

        if (found)
        {
            Console.WriteLine($"{number} , {list.IndexOf(number)}");
        }
    }
}