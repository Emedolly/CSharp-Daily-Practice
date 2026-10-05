namespace Day02;

public class WordCount
{
    public void Run()
    {
        string words = "Apple Banana Apple";
        string[] names = words.Split(" ");
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (string word in names)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount.Add(word, 1);
            }
        }

        foreach (var item in wordCount)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}