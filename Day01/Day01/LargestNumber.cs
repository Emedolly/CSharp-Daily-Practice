namespace Day01;

public class LargestNumber
{
    public void Run()
    {
        int[] numbers = {10, 2, 3,8,9 };
        int largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine(largest);
    }
}