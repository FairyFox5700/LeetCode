public class Solution
{
    public int MinOperations(int[] nums)
    {
        int count = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                // Calculate the difference and add it to count
                int diff = Math.Abs(nums[i] - nums[i - 1]) + 1;
                count += diff;
                // Update nums[i] to make it greater than nums[i-1]
                nums[i] = nums[i - 1] + 1;
            }
        }
        return count;
    }
}
