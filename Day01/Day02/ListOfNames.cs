namespace Day02;

public class ListOfNames
{
    public void Run()
    {
        List<string> names = new List<string>() { "Ani", "BHI", "AMI" };
        foreach (string name in names)
        {
            if (name.StartsWith("A"))
            {
                Console.WriteLine(name);
            }
        }
    }
}