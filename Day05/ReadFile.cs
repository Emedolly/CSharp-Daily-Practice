namespace Day05;

public class ReadFile
{
    public void Run()
    {
       string readText= File.ReadAllText("/Users/emeema/Desktop/text/untitled.txt");
       Console.WriteLine(readText);
    }
}