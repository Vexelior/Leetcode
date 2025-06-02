namespace Remove_Duplicates_from_Sorted_Array;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        int newLength = RemoveDuplicates(nums);

        Console.WriteLine($"New length: {newLength}");
        Console.WriteLine("Modified array: " + string.Join(", ", nums.Take(newLength)));
    }

    // This method removes duplicates from a sorted array in-place and returns the new length of the array.
    // It uses the two-pointer technique to overwrite duplicate elements with unique ones.
    private static int RemoveDuplicates(int[] nums)
    {
        // If the array has 0 or 1 element, it's already unique.
        if (nums.Length < 2) return nums.Length;

        // `uniqueIndex` keeps track of the position of the last unique element in the array.
        int uniqueIndex = 0;

        // Iterate through the array starting from the second element.
        for (int i = 1; i < nums.Length; i++)
        {
            // Only update when a new unique element is found.
            if (nums[i] != nums[uniqueIndex])
            {
                nums[++uniqueIndex] = nums[i];
            }
        }

        // Return the count of unique elements, which is `uniqueIndex + 1`.
        return uniqueIndex + 1;
    }
}