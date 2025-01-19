public class Solution {
    public void WiggleSort(int[] nums) 
    {
        for( int i = 0; i< nums.Length-1; i++)
        {

            if(i%2 == 0)
            {
               if(nums[i] > nums[i+1])
                {
                    (nums[i], nums[i+1]) = (nums[i+1], nums[i]);
                }
            }
            else
            {
                if(nums[i] < nums[i+1])
                {
                    (nums[i], nums[i+1]) = (nums[i+1], nums[i]);
                }
            }

        }



    }
}