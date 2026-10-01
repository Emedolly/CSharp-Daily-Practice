namespace Day01;

public class Palindrome
{
    public void Run()
    {
        string word = "Hello";
        string result = string.Empty;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }

        if (word == result)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}