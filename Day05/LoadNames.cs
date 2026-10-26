namespace Day05;

public class LoadNames
{
    public void Run()
    {
        string[] names = File.ReadAllLines("/Users/emeema/Desktop/text/SaveNames.txt");
        if (!File.Exists("/Users/emeema/Desktop/text/SaveNames.txt"))
        {
            Console.WriteLine("File not found");
        }
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}