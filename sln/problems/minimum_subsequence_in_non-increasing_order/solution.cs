 public class Solution
 {
     public IList<int> MinSubsequence(int[] nums)
     {
         Array.Sort(nums);
         var sum = nums.Sum();
         var result = new List<int>();
         var currentSum = 0;
         if (nums.Count() == 1)
         {
             return nums.ToList();
         }
         for (int i = nums.Length - 1; i >= 1; i--)
         {
             result.Add(nums[i]);
             currentSum += nums[i];
             if (currentSum > sum - currentSum)
             {
                 return result;
             }
             if (currentSum + nums[i - 1] > sum - currentSum - nums[i - 1])
             {
                 result.Add(nums[i - 1]);
                 return result;
             }
         }

         return result;
     }
 }