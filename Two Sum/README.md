# Solution

## Problem Description

The Two Sum problem on Leetcode requires finding two numbers in an array that add up to a specific target. The solution should return the indices of these two numbers.

## Solution Explanation

The provided solution is a brute-force approach implemented in C#. It uses nested loops to check all possible pairs of numbers in the array.

### Code

```csharp
private static int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    throw new ArgumentException("No two sum solution exists for the given input.");
}
```

### How It Works

1. **Outer Loop**: Iterates through each element in the array (`nums[i]`).
2. **Inner Loop**: For each element in the outer loop, iterates through the subsequent elements (`nums[j]`).
3. **Condition Check**: If the sum of `nums[i]` and `nums[j]` equals the target, their indices are returned as an array.
4. **Exception Handling**: If no such pair exists, an exception is thrown.

### Complexity

- **Time Complexity**: O(n²) due to the nested loops.
- **Space Complexity**: O(1) as no additional data structures are used.

### Example

Input:

```text
nums = [2, 7, 11, 15], target = 9
```

Output:

```text
[0, 1]
```

Explanation: `nums[0] + nums[1] = 2 + 7 = 9`.

## Limitations

- This approach is not optimal for large arrays due to its O(n²) time complexity.
- A more efficient solution can be implemented using a hash table to achieve O(n) time complexity.

## Conclusion

This brute-force solution is simple and easy to understand but may not be suitable for scenarios requiring high performance. For larger datasets, consider optimizing the algorithm.
