# Solution

## Problem Description

The Roman to Integer problem on LeetCode requires converting a string representing a Roman numeral into its integer equivalent. The solution should handle various Roman numeral symbols and their combinations.

## Solution Explanation

The provided solution is a straightforward approach implemented in C#. It uses a dictionary to map Roman numeral symbols to their integer values and iterates through the string to compute the total value.

### Code

```csharp
    private static int RomanToInt(string s)
    {
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

        int total = 0;
        int prevValue = 0;

        foreach (char c in s)
        {
            int currentValue = romanMap[c];
            if (currentValue > prevValue)
            {
                total += currentValue - 2 * prevValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }
```

### How It Works

1. **Dictionary Initialization**: A dictionary `romanMap` is created to map each Roman numeral character to its corresponding integer value.
2. **Total and Previous Value**: Two variables, `total` and `prevValue`, are initialized to keep track of the cumulative total and the value of the previous Roman numeral character.
3. **Iteration**: The method iterates through each character in the input string `s`.
4. **Value Calculation**:
   - If the current Roman numeral value is greater than the previous value, it indicates a subtractive combination (e.g., IV = 4). The current value is added to the total, and twice the previous value is subtracted to account for the earlier addition.
   - If the current value is less than or equal to the previous value, it is simply added to the total.
5. **Update Previous Value**: The `prevValue` is updated to the current value for the next iteration.

### Complexity

- **Time Complexity**: O(n), where n is the length of the input string `s`. The method processes each character exactly once.
- **Space Complexity**: O(1), as the dictionary size is constant and does not depend on the input size.

### Example

Input:

```text
s = "MCMXCIV"
```

Output:

```text
1994
```

Explanation: The Roman numeral "MCMXCIV" is broken down as follows:

- M = 1000
- CM = 900 (1000 - 100)
- XC = 90 (100 - 10)
- IV = 4 (5 - 1)
- Total = 1000 + 900 + 90 + 4 = 1994

### Limitations

- The solution assumes that the input string is a valid Roman numeral. Invalid inputs may lead to unexpected results.

### Conclusion

This solution effectively converts Roman numerals to integers using a clear and efficient approach. It handles both additive and subtractive combinations of Roman numeral symbols, ensuring accurate conversion for all valid inputs. The algorithm is efficient with linear time complexity, making it suitable for practical use cases. For further optimization, consider edge cases or additional validation if necessary.
