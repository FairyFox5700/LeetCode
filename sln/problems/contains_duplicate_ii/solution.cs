public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var hashSet = new HashSet<int>();
        int l = 0;
        for(var r = 0;  r < nums.Count(); r++)
        {
            if(r-l >k)
            {
                // decrease windows size
                hashSet.Remove(nums[l]);
                l+=1;
            }
            if(hashSet.Contains(nums[r]))
            {
                return true;
            }
            else
            {
                hashSet.Add(nums[r]);
                
            }
        }
        return false;
    }
}