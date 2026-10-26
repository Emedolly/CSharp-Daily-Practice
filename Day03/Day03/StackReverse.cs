namespace Day03;

public class StackReverse
{
    public void Run()
    {
        string text = "Hello";
        Stack<char> stack = new Stack<char>();
        string result = string.Empty;
        foreach (char c in text)
        {
            stack.Push(c);
        }

        while (stack.Count > 0)
        {
            result = result + stack.Pop();
        }
        Console.WriteLine(result);
    }
}