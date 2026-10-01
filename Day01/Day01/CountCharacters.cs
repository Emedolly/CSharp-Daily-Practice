namespace Day01;

public class CountCharacters
{
    public  void Run()
    {
        string sentence = "Hello world";
        int count = 0;
        foreach (char c in sentence)
        {
            count++;
        }

        if (sentence.Length == count)
        {
            Console.WriteLine("The number of characters are " + count);
        }
    }
}