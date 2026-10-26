namespace Day03;

public class StudentMarks
{
    public void Run()
    {
        Dictionary<string, List<int>> marks = new Dictionary<string, List<int>>();
        marks.Add("A", new List<int>() {1,2,3});
        marks.Add("B", new List<int>() {4,5,6});
        marks.Add("C", new List<int>() {7,8,9});
        string topperName = "";
        double topperAverage= Double.MinValue;
        foreach (KeyValuePair<string, List<int>> pair in marks)
        {
           int total = 0;
           foreach (int value in pair.Value)
           {
               total += value;
           }
           double average = (double)total / pair.Value.Count;    // (double) so 6/3 is not cut into whole numbers

           Console.WriteLine($"{pair.Key}: total = {total}, average = {average}");

           if (average > topperAverage)                  // is this student better than the best so far?
           {
               topperAverage = average;                  // yes, remember the new best average
               topperName = pair.Key;                    // and remember the name
           }
        }
        Console.WriteLine($"Topper: {topperName} with average {topperAverage}"); 
    }
}