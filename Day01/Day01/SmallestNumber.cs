namespace Day01;

public class SmallestNumber
{
 public void Run()
 {
  int[] numbers = { 4,9,2,7};
  int smallest = numbers[0];
  for (int i = 1; i < numbers.Length; i++)
  {
   if (numbers[i] < smallest)
   {
    smallest = numbers[i];
   }
  }
  Console.WriteLine(smallest);
 }   
}