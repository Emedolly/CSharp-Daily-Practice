namespace Day01;

public class ReverseString
{
    private string word = "Hello";
    string result = string.Empty;

    public void Run()
    {
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result +=word[i];
        }
        Console.WriteLine(result);
    }
}