using System;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        // We adjust the pointer start position to nums.Length - 1
        int pointer = nums.Length - 1;

        // Find the first element from the end that is smaller than the previous one.
        while (pointer > 0 && nums[pointer - 1] >= nums[pointer])
        {
            pointer--;
        }

        // Adjust pointer to point to the element before the first found decrease.
        pointer--;

        if (pointer >= 0)
        {
            int switchIndex = nums.Length - 1;
            // Find the element that is larger than the element at pointer to swap with.
            while (nums[switchIndex] <= nums[pointer])
            {
                switchIndex--;
            }

            // Swap the found elements.
            (nums[pointer], nums[switchIndex]) = (nums[switchIndex], nums[pointer]);
        }

        // Reverse the elements from pointer + 1 to the end to get the next permutation.
        // If no valid pointer was found, pointer will be -1 and thus reversing from 0 to end.
        Array.Reverse(nums, pointer + 1, nums.Length - pointer - 1);
    }
}
