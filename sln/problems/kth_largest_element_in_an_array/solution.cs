public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        if (k < 1 || k > nums.Length)
        {
            throw new ArgumentException("k is out of range");
        }

        // Convert k to the (nums.Length - k)-th element
        int targetIndex = nums.Length - k;

        return KthLargest(nums, targetIndex, 0, nums.Length - 1);
    }

    private int KthLargest(int[] nums, int k, int low, int high)
    {
        int pivotIndex = QuickSelect(nums, low, high);

        if (pivotIndex == k)
        {
            return nums[pivotIndex];
        }
        else if (pivotIndex > k)
        {
            return KthLargest(nums, k, low, pivotIndex - 1);
        }
        else
        {
            return KthLargest(nums, k, pivotIndex + 1, high);
        }
    }

    private int QuickSelect(int[] nums, int low, int high)
    {
        int pivotIndex = high;
        int swapIndex = low;

        for (int i = low; i < high; i++)
        {
            if (nums[i] <= nums[pivotIndex])
            {
                (nums[i], nums[swapIndex]) = (nums[swapIndex], nums[i]);
                swapIndex++;
            }
        }

        (nums[swapIndex], nums[pivotIndex]) = (nums[pivotIndex], nums[swapIndex]);
        return swapIndex;
    }
}
