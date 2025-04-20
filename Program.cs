namespace FindPalindrome;

class Program
{
    /// <summary>
    /// Checks whether the given string is a palindrome, ignoring case and non-alphanumeric characters.
    /// </summary>
    /// <param name="input">The input string to evaluate.</param>
    /// <returns>True if the input is a palindrome; otherwise, false.</returns>
    public static bool IsPalindrome(string input)
    {
        var cleanedBuilder = new System.Text.StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanedBuilder.Append(char.ToLower(c));
            }
        }

        var cleaned = cleanedBuilder.ToString();
        int left = 0, right = cleaned.Length - 1;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
                return false;
            left++;
            right--;
        }

        return true;
    }

    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        Console.WriteLine(IsPalindrome(input));

        Console.ReadLine();
    }
}
