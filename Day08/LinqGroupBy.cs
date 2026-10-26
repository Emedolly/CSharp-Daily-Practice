namespace Day08;

public class LinqGroupBy
{
    public static void Run()
    {
        string words = "cat dog apple fig banana";
        string[] wordsArray = words.Split(" ");
        var result = wordsArray.GroupBy(n => n.Length).ToList();
        //Console.WriteLine(string.Join(",", result)); will not give result 
        foreach (var group in result)
        {
            Console.WriteLine($"{group.Key}: {string.Join(" ", group)}");
        }
    }
}