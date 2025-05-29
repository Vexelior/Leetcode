namespace Longest_Common_Prefix;

public static class Program
{
    public static void Main(string[] args)
    {
        string[] strs = { "flower", "flow", "flight" };
        string result = LongestCommonPrefix(strs);
        Console.WriteLine(result); // Output: "fl"
    }

    private static string LongestCommonPrefix(string[] strs)
    {
        // Sort the array to bring similar prefixes together
        Array.Sort(strs);

        // The first and last strings will have the minimum common prefix after sorting
        string first = strs[0];
        string second = strs[^1];
        int minimumLength = Math.Min(first.Length, second.Length);
        int iteration = 0;

        // Compare characters of the first and last strings until they differ
        while (iteration < minimumLength && first[iteration] == second[iteration])
        {
            iteration++;
        }

        // Return the common prefix found
        return first[..iteration];
    }
}
