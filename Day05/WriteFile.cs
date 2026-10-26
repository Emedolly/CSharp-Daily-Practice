namespace Day05;

public class WriteFile
{
    public void Run()
    {
        string text = "Hey hi";
        File.WriteAllText(@"/Users/emeema/Desktop/text/untitled.txt",text);
    }
}