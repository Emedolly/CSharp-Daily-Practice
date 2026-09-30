namespace Day01;

public class CountEvenOdd
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int odd = 0;
        int even=0;
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine($"Odd: {odd}");
        Console.WriteLine($"Even: {even}");
    }
}