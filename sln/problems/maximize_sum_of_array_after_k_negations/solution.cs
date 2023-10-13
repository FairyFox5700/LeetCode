 public class Solution
 {
     public int LargestSumAfterKNegations(int[] nums, int k)
     {
         var pq = new PriorityQueue<int,int>();
         for (int i = 0; i < nums.Length; i++)
         {
                pq.Enqueue(nums[i], nums[i]);
         }

         while (k>0)
         {
             var item = pq.Dequeue();
             pq.Enqueue(-item, -item);
             k--;
         }

         var sum = 0;
         while (pq.Count>0)
         {
             sum +=pq.Dequeue();
         }

         return sum;
     }
 }