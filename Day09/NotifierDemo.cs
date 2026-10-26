namespace Day09;

public static class NotifierDemo
{
    //ALERT: takes ANY plug that signed INotifier. It does not care which one
    public static void Alert(INotifier notifier)
    {
        notifier.Send("server down");
    }

    public static void Run()
    {
        ConsoleNotifier notifier = new ConsoleNotifier();
        UppercaseNotifier uppercaseNotifier = new UppercaseNotifier();
        Alert(notifier);
        Alert(uppercaseNotifier);
    }
}

public interface INotifier
{
    void Send(string message);
}

public class ConsoleNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}

public class UppercaseNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine(message.ToUpper());
    }
}