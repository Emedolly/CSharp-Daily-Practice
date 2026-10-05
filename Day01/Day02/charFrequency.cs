namespace Day02;

public class charFrequency
{
    public void Run()
    {
        string word = "Hello";
        Dictionary<char,int> characterFrequency = new Dictionary<char,int>();
        foreach (char c in word)
        {
            if (characterFrequency.ContainsKey(c))
            {
                characterFrequency[c]++;
            }
            else
            {
                characterFrequency[c] = 1;
            }
        }

        foreach (KeyValuePair<char, int> pair in characterFrequency)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}