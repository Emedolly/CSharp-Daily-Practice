namespace Day01;

public class SumOfArray
{
    public void Run()
    {
        int[] numbers = { 4, 9, 2, 7 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }
        Console.WriteLine(sum);
    }
}