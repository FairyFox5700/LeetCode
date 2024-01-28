public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        Array.Sort(nums);// [10,1,2,7,1,3]
        //[1, 2, 3, 7, 10]
   
        var left = 0;
        var right = nums[^1] - nums[0];
        // binary search
        while(left< right)
        {
            var mid = left + (right -left)/2;
            // trying this trashold to find p count of valid CountOfValidPairs
            var count = CountOfValidPairs(nums, mid);
            if( count >= p)
                right = mid;
            if( count < p)
                left = mid + 1;
        }

        return left;

    }

    public int CountOfValidPairs(int[] nums, int treshold)
    {
        var count = 0;
        for(int i =0; i< nums.Count()-1; i++)
        {
            var diff = nums[i+1] - nums[i];
            if(diff<= treshold)
            {
                count++;
                i++; // skip as we found a pair
            }
        }

        return count;
    }
}