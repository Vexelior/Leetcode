namespace Remove_Element;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        int newLength = RemoveElement(nums, val);

        Console.WriteLine($"New length: {newLength}");
        Console.WriteLine("Modified array: " + string.Join(", ", nums.Take(newLength)));
    }

    // Removes all instances of 'val' from the array 'nums' in-place and returns the new length.
    private static int RemoveElement(int[] nums, int val)
    {
        int k = 0; // Pointer for the next position to place a non-'val' element.
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current element is not equal to 'val', keep it in the array.
            if (nums[i] != val)
            {
                nums[k] = nums[i]; // Move the non-'val' element to the front.
                k++; // Increment the position for the next non-'val' element.
            }
        }
        // 'k' is the new length of the array with all 'val' elements removed.
        return k;
    }
}