namespace Two_Sum;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }

    // Finds two indices in the array whose values sum up to the target.
    private static int[] TwoSum(int[] nums, int target)
    {
        // Iterate through each element in the array.
        for (int i = 0; i < nums.Length; i++)
        {
            // For each element, check the rest of the elements after it.
            for (int j = i + 1; j < nums.Length; j++)
            {
                // If the sum of the two elements equals the target, return their indices.
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No two sum solution exists for the given input.");
    }
}