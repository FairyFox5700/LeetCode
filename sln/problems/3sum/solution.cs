public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var list = new List<IList<int>>();
        var firstVal = int.MaxValue;
        if(nums.Count() < 3)
        {
            return list;
        }
        for(int i = 0; i< nums.Count()-1; i++)
        {
            // the same idea as two sum, first we find the first value, then the problem is 2 sum
           
            if(firstVal == nums[i])
            {
                continue;
            }
            firstVal = nums[i];
            var left = i+1;
            var right = nums.Count() -1;
            while(left < right)
            {
                var current = firstVal + nums[left] + nums[right];
                if( right == left)
                {
                    continue;
                }
                if(current == 0)
                {
                   list.Add( new List<int>
                   {
                       firstVal, nums[left], nums[right]
                   });
                   while (left< right && nums[left] == nums[left+1])
                   {
                       left ++;
                   }
                   while (left< right && nums[right] ==nums[right-1])
                   {
                        right --;
                   }
                    left ++;
                    right --;
                }
                else if ( current > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return list;

    }

}