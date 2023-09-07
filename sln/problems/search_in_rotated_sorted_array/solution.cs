public class Solution {
    public int Search(int[] nums, int target) {
        // binary search
        var left = 0;
        var right = nums.Count() -1;
        while(left<= right)
        {
            var mid = (left + right) / 2;
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid]>= nums[left])
            {
                // mean left side is sorter
                if(target >= nums[left] && target < nums[mid])
                {
                    right = mid -1; // continue search in the left part of array
                }
                else{
                    // right part
                    left = mid +1;
                }
            }
            else
            {
                // mean right side is sorted
                if(target > nums[mid] && target <= nums[right])
                {
                     left = mid +1;
                }
                else{
                    right = mid -1; // continue search in the left part of array
                }
            }
        }

        return -1;
    }
}