namespace Day06;

public static class stringExtensions
{
    public static bool IsPalindrome(this string text)
    {
        string clean = text.ToLower(); 
        int left = 0;                                     // pointer at the first letter
        int right = clean.Length - 1;                     // pointer at the last letter

        while (left < right)                              // walk inward from both ends
        {
            if (clean[left] != clean[right])              // letters differ: not a palindrome
                return false;

            left++;                                       // move inward
            right--;
        }
        return true;    
    }
}