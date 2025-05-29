namespace Palindrome_Number;

public static class Program
{
    public static void Main(string[] args)
    {
        // Example 1
        int x1 = 121;
        bool result1 = IsPalindrome(x1);
        Console.WriteLine($"Is {x1} a palindrome? {result1}"); // Output: true

        // Example 2
        int x2 = -121;
        bool result2 = IsPalindrome(x2);
        Console.WriteLine($"Is {x2} a palindrome? {result2}"); // Output: false

        // Example 3
        int x3 = 10;
        bool result3 = IsPalindrome(x3);
        Console.WriteLine($"Is {x3} a palindrome? {result3}"); // Output: false
    }

    // Given an integer x, return true if x is a palindrome, and false otherwise.
    private static bool IsPalindrome(int x)
    {
        // Negative numbers and numbers ending with 0 (except 0 itself) cannot be palindromes
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        int reversed = 0;
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        // For odd-length numbers, we can ignore the middle digit by using reversed / 10
        return x == reversed || x == reversed / 10;
    }
}