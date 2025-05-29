namespace Roman_to_Integer;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(RomanToInt("III")); // Output: 3
        Console.WriteLine(RomanToInt("IV"));  // Output: 4
        Console.WriteLine(RomanToInt("IX"));  // Output: 9
        Console.WriteLine(RomanToInt("LVIII")); // Output: 58
        Console.WriteLine(RomanToInt("MCMXCIV")); // Output: 1994
    }

    // Converts a Roman numeral string to its integer value
    private static int RomanToInt(string s)
    {
        // Mapping of Roman numeral characters to their integer values
        Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;      // Stores the final integer value
        int prevValue = 0;  // Stores the value of the previous Roman numeral character

        // Iterate through each character in the Roman numeral string
        foreach (char c in s)
        {
            int currentValue = romanMap[c]; // Get the integer value of the current character

            // If the current value is greater than the previous value,
            // it means we need to subtract twice the previous value (as it was added before)
            if (currentValue > prevValue)
            {
                total += currentValue - 2 * prevValue; // Adjust total for subtractive notation
            }
            else
            {
                total += currentValue; // Add the current value to the total
            }

            prevValue = currentValue; // Update previous value for next iteration
        }

        return total; // Return the computed integer value
    }
}
