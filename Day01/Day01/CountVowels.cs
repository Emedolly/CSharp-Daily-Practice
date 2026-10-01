namespace Day01;

public class CountVowels
{
    public void Run()
    {
        string word = "education";
        int consonants = 0;
        int vowels = 0;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
            {
                vowels++;
            }
            else
            {
                consonants++;
            }
        }

        Console.WriteLine($"Vowels:{vowels}");
        
    }
}