# Solution

## Problem Description

Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

## Solution Explanation

This solution involves iterating through the array and using a two-pointer technique to remove all occurrences of a specified value (`val`). The first pointer traverses the array, while the second pointer keeps track of the position to place the next non-`val` element.

### Code

```csharp
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
```

### Key Steps in the Algorithm:

1. Initialize a counter `k` to keep track of the position for the next non-`val` element.
2. Iterate through each element in the array using a for loop.
3. If the current element is not equal to `val`, assign it to the position indicated by `k` and increment `k`.
4. After the loop, `k` will represent the number of elements in the modified array that are not equal to `val`.
5. Return `k` as the result, which is the count of elements not equal to `val`.

### Complexity Analysis:

- **Time Complexity**: O(n), where n is the number of elements in the array. We traverse the array once.
- **Space Complexity**: O(1), since we are modifying the array in-place and not using any additional data structures.

## Example Usage

```csharp
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        int newLength = RemoveElement(nums, val);

        Console.WriteLine($"New length: {newLength}");
        Console.WriteLine("Modified array: " + string.Join(", ", nums.Take(newLength)));
```

## Conclusion

This solution efficiently removes all occurrences of a specified value from an array in-place, using a simple two-pointer technique. The modified array retains the order of the remaining elements, and the solution runs in linear time with constant space usage.
