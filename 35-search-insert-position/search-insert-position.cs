public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        // simple binary search

        var left = 0;
        var right = nums.Length - 1;
        var mid = 0;
        while(left<=right)
        {
            mid = left + (right-left)/2;

            if (nums[mid]== target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}
