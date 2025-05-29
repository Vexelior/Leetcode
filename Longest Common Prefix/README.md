# Solution

# Problem Description

Given an array of strings, find the longest common prefix string amongst them. If there is no common prefix, return an empty string "".

# Solution Explanation

The solution involves iterating through the characters of the first string and checking if all other strings have the same character at the same position. If a mismatch is found, the common prefix is returned up to that point.

### Code

```csharp
    private static string LongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);

        string first = strs[0];
        string second = strs[^1];
        int minimumLength = Math.Min(first.Length, second.Length);
        int iteration = 0;

        while (iteration < minimumLength && first[iteration] == second[iteration])
        {
            iteration++;
        }

        return first[..iteration];
    }
```

# How It Works

The code first sorts the array of strings. By comparing only the first and last strings in the sorted order, it ensures that the common prefix is found efficiently. The loop continues until a mismatch is found or the end of the shorter string is reached, returning the common prefix found so far.

# Complexity

The time complexity of this solution is O(n \* m), where n is the number of strings and m is the length of the shortest string. The sorting step takes O(n log n) time, but since we only compare the first and last strings after sorting, the overall complexity remains dominated by the character comparisons.

# Example

```csharp
string[] strs = { "flower", "flow", "flight" };
string result = LongestCommonPrefix(strs);
Console.WriteLine(result); // Output: "fl"
```

# Limitations

This solution assumes that the input array is not empty. If the array can be empty, additional checks should be added to handle such cases gracefully.

# Conclusion

This solution efficiently finds the longest common prefix among an array of strings by leveraging sorting and character comparison. It is straightforward and works well for typical use cases where the input is not empty.
