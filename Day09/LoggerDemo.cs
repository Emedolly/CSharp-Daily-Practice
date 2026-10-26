namespace Day09;

public static class LoggerDemo
{
    public static void Run()
    {
        // Plug 1: normal logger
        ConsoleLogger consoleLogger = new ConsoleLogger();
        Calculator calc1 = new Calculator(consoleLogger);    // hand the plug in through the constructor

        // Plug 2: uppercase logger
        UpperLogger upperLogger = new UpperLogger();
        Calculator calc2 = new Calculator(upperLogger);      // same Calculator class, different plug

        int answer1 = calc1.Add(2, 3);                       // logs with ConsoleLogger, returns 5
        int answer2 = calc2.Add(2, 3);                       // logs with UpperLogger, returns 5

        Console.WriteLine($"Answer 1: {answer1}");           // Answer 1: 5
        Console.WriteLine($"Answer 2: {answer2}");           // Answer 2: 5 
    }
}

public interface ILogger
{
    void Log(string text);
}

public class ConsoleLogger : ILogger
{
    public void Log(string text)
    {
        Console.WriteLine(text);
    }
}

public class UpperLogger : ILogger
{
    public void Log(string text)
    {
        Console.WriteLine(text.ToUpper());
    }
}

public class Calculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public int Add(int x, int y)
    {
        int result = x + y;
        _logger.Log("Adding " + x + " to " + y + $"result {result}");
        return result;
    }
}