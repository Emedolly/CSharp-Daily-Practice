namespace Day05;

public class SaveNames
{
    public void Run()
    {
        List<string> names = new List<string>(){"name A", "name B", "name C"};
        File.WriteAllLines("/Users/emeema/Desktop/text/SaveNames.txt", names);
    }
}