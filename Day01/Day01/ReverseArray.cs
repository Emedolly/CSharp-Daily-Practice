namespace Day01;

public class ReverseArray
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4};
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);
        }
    }
}