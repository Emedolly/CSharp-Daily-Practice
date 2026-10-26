namespace Day03;

public class GroupByLength
{
    public void Run()
    {
        string text = "cat dog apple fig banana";
        string[] words = text.Split(' ');
        Dictionary<int, List<string>> groups = new Dictionary<int, List<string>>();
        foreach (string word in words)
        {
            if (!groups.ContainsKey(word.Length))
            {
                groups[word.Length] = new List<string>();
            }
            groups[word.Length].Add(word);
        }

        foreach (KeyValuePair<int, List<string>> group in groups)
        {
            Console.WriteLine($"{group.Key}: {string.Join(" ", group.Value)}");
        }
    }
}