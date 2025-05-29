# Solution

## Problem Description

Given an integer `x`, return `true` if `x` is a palindrome, and `false` otherwise.

## Solution Explanation

The solution is implemented in C# using the following method:

### Code

```csharp
private static bool IsPalindrome(int x)
{
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
    return x == reversed || x == reversed / 10;
}
```

### Key Steps in the Algorithm:

1. **Handle Edge Cases**:

   - If `x` is negative, return `false`.
   - If `x` ends with `0` but is not `0`, return `false`.

2. **Reverse Half of the Number**:

   - Use a `while` loop to reverse the digits of the number until the reversed half is greater than or equal to the remaining half.

3. **Compare Halves**:
   - For even-length numbers, check if the reversed half equals the remaining half.
   - For odd-length numbers, ignore the middle digit by dividing the reversed half by `10` and then compare.

### Complexity Analysis:

- **Time Complexity**: O(log₁₀(n)), where `n` is the input number. This is because we process approximately half the digits of the number.
- **Space Complexity**: O(1), as no additional data structures are used.

## Example Usage

```csharp
Console.WriteLine(IsPalindrome(121)); // Output: true
Console.WriteLine(IsPalindrome(-121)); // Output: false
Console.WriteLine(IsPalindrome(10)); // Output: false
Console.WriteLine(IsPalindrome(0)); // Output: true
```

## Conclusion

This solution efficiently determines whether a number is a palindrome by reversing only half of its digits and comparing it with the other half. It avoids converting the number to a string, making it more optimal in terms of both time and space complexity.
