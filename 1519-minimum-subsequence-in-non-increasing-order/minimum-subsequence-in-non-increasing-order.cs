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
         for (int i = nums.Length - 1; i >= 0; i--)
         {
             result.Add(nums[i]);
             currentSum += nums[i];
             if (currentSum > sum - currentSum)
             {
                 return result;
             }
   
         }

         return result;
     }
 }