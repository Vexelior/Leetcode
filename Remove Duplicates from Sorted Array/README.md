# Solution

## Problem Description

Given a sorted array `nums`, remove the duplicates in-place such that each element appears only once and return the new length of the array. Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

## Solution Explanation

The solution involves iterating through the sorted array and maintaining a pointer for the last unique element found. When a new unique element is encountered, it is placed at the next position after the last unique element. This way, we ensure that all duplicates are skipped, and the array is modified in-place.

### Code

```csharp
    private static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;

        int uniqueIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueIndex])
            {
                nums[++uniqueIndex] = nums[i];
            }
        }

        return uniqueIndex + 1;
    }
```

### Key Steps in the Algorithm:

1. Check if the array length is less than 2. If so, return the length as there are no duplicates.
2. Initialize a pointer `uniqueIndex` to track the position of the last unique element.
3. Iterate through the array starting from the second element.
4. For each element, check if it is different from the last unique element.
5. If it is different, increment the `uniqueIndex` and place the current element at that position.
6. Continue until the end of the array.
7. Return `uniqueIndex + 1` as the new length of the array.

### Complexity Analysis:

- **Time Complexity**: O(n), where n is the number of elements in the array. We traverse the array once.
- **Space Complexity**: O(1), as we are modifying the array in-place without using extra space.

## Example Usage

```csharp
        int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        int newLength = RemoveDuplicates(nums);

        Console.WriteLine($"New length: {newLength}");
        Console.WriteLine("Modified array: " + string.Join(", ", nums.Take(newLength)));
        // Output:
        //New length: 5
        //Modified array: 1, 2, 3, 4, 5
```

## Conclusion

This solution efficiently removes duplicates from a sorted array in-place, ensuring that the original array is modified without using additional space. The algorithm runs in linear time and uses constant space, making it optimal for this problem.
