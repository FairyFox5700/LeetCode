public class Solution {
    public int MaxOperations(int[] nums, int k) 
    {
        Array.Sort(nums);
        int count = 0;
        int left = 0;
        int right = nums.Length -1;

        while(left< right)
        {
            if(nums[left]+ nums[right] > k)
            {
                right--;
            }
            else if(nums[left]+ nums[right] < k)
            {
                left++;
            }
            else{
                count++;
                left++;
                right--;
            }

        }

        return count;
    }
}