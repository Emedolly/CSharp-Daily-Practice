namespace Day06;

public class SimpleDelegate
{
    public static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    public Action<string> greet = SayHello;
}