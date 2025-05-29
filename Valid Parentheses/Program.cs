namespace Valid_Parentheses;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsValid("()")); // True
        Console.WriteLine(IsValid("()[]{}")); // True
        Console.WriteLine(IsValid("(]")); // False
        Console.WriteLine(IsValid("([)]")); // False
        Console.WriteLine(IsValid("{[]}")); // True
    }

    // Checks if the input string has valid parentheses
    private static bool IsValid(string s)
    {
        // Stack to keep track of opening parentheses
        Stack<char> stack = new Stack<char>();
        // Map of opening to corresponding closing parentheses
        Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'},
        };

        // Iterate through each character in the string
        foreach (char c in s)
        {
            // If it's an opening parenthesis, push to stack
            if (parenthesesMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            // If it's a closing parenthesis
            else if (parenthesesMap.ContainsValue(c))
            {
                // If stack is empty or the top doesn't match, return false
                if (stack.Count == 0 || parenthesesMap[stack.Pop()] != c)
                {
                    return false;
                }
            }
        }

        // If stack is empty, all parentheses were matched
        return stack.Count == 0;
    }
}