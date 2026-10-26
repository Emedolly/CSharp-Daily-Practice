namespace Day03;

public class GenericSwap
{
   public void Swap<T>(ref T x, ref T y)
   {
      T temp = x;
      x = y;
      y = temp;
   }

   public void Run()
   {
      int x = 10;
      int y = 5;
      Console.WriteLine($"Before {x} {y}");
      Swap(ref x, ref y);
      Console.WriteLine($"After {x} {y}");
   }
}
