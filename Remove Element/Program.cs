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

    private static int RemoveElement(int[] nums, int val)
    {
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
}