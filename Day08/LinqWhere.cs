namespace Day08;

public static class LinqWhere
{
    public static void Run()
    {
        List<int> list = new List<int>() { 5, 3, 8, 1, 9, 2, 8 };
        List<int> result = list.Where(x => x > 4).ToList();
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
       Console.WriteLine(); 
    }
}