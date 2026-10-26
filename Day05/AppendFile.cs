namespace Day05;

public class AppendFile
{
    public void Run()
    {
        string newText = "\nThis is Eme";
        File.AppendAllText("/Users/emeema/Desktop/text/untitled.txt", newText);
    }
}