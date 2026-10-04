namespace Day02;

public class SecondLargest
{
    public  void Run()
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        int[] numbers = { 4, 9, 2, 7 };
        foreach (var number in numbers)
        {
            if (number > largest)
            {
                secondLargest = largest;
                largest = number;
            }
            else if (number > secondLargest && number != largest)
            {
                secondLargest =  number;
            }
        }
        Console.WriteLine($"{secondLargest} largest");
    }
}