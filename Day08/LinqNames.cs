namespace Day08;

public class LinqNames
{
    public static void Run()
    {
        List<string> names = new List<string>() { "Anu", "Amit", "Anim" };
        var result = names.Where(name => name.StartsWith("A")).OrderBy(name => name).Select(name => name.ToUpper());
        Console.WriteLine(string.Join(" ", result));
    }
}