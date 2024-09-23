using System;

public class Solution
{
    private int[,] _freq;

    public int MaxOperations(int[] nums)
    {
        // Initialize the memoization table
        _freq = new int[nums.Length, nums.Length];

        // If the array has fewer than 2 elements, no operations can be performed
        if (nums.Length < 2) return 0;

        // Recursive DFS calls to find the maximum number of operations for each sum scenario
        int firstSumOperations = DFS(2, nums.Length - 1, nums, nums[0] + nums[1]);
        int lastSumOperations = DFS(0, nums.Length - 3, nums, nums[nums.Length - 2] + nums[nums.Length - 1]);
        int firstAndLastSumOperations = DFS(1, nums.Length - 2, nums, nums[0] + nums[nums.Length - 1]);

        // Return the maximum operations count among all possibilities
        return 1+Math.Max(firstSumOperations, Math.Max(lastSumOperations, firstAndLastSumOperations));
    }

    private int DFS(int left, int right, int[] nums, int target)
    {
        // Base case: if the subarray has fewer than 2 elements
        if (right - left < 1) return 0;

        // If already computed, return the stored result from memoization table
        if (_freq[left, right] != 0) return _freq[left, right];

        int answ = 0;

        // Case 1: If the sum of the first two elements equals the target
        if (left + 1 < nums.Length && nums[left] + nums[left + 1] == target)
        {
            answ = Math.Max(1 + DFS(left + 2, right, nums, target), answ);
        }

        // Case 2: If the sum of the last two elements equals the target
        if (right - 1 >= 0 && nums[right] + nums[right - 1] == target)
        {
            answ = Math.Max(1 + DFS(left, right - 2, nums, target), answ);
        }

        // Case 3: If the sum of the first and last elements equals the target
        if (nums[left] + nums[right] == target)
        {
            answ = Math.Max(1 + DFS(left + 1, right - 1, nums, target), answ);
        }

        // Store the result in the memoization table
        _freq[left, right] = answ;
        return answ;
    }
}
