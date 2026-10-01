namespace Day01;

public class PrimeNumber
{
    public void Run(int number)
    {
        bool isPrime = true;
        if (number == 1 || number <= 1)
        {
            isPrime = false;
        }

        if (number % 2 == 0)
        {
            isPrime = false;
        }
        else
        {
            isPrime = true;
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} is prime");
        }
        else
        {
            Console.WriteLine($"{number} is NOT prime");
        }
    }
}