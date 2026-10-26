namespace Day09;

public static class PayDemo
{
    public static void Run()
    {
        Salaried salaried = new Salaried(5000);
        HourlySalaried hourly = new HourlySalaried(100m, 40);
        Console.WriteLine("Salaried: " + salaried.GetPay());
        Console.WriteLine("Hourly: " + hourly.GetPay());
    }
}

public interface IPayable
{
    decimal GetPay();
}

public class Salaried : IPayable
{
    public decimal Amount { get; set; }
    public Salaried(decimal amount)
    {
        Amount = amount;
    }

    public decimal GetPay()
    {
         return Amount;
    }
}

public class HourlySalaried : IPayable
{
    public decimal Rate { get; set; }
    
    public int Hours { get; }

    public HourlySalaried(decimal rate, int hours)
    {
        Rate = rate;
        Hours = hours;
    }

    public decimal GetPay()
    {
        return Rate*Hours;
    }
}