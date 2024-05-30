    public class Solution
    {
        public int KBigIndices(int[] nums, int k)
        {
            var pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b-a));
            var hashSet = new HashSet<int>();
            //3,8,4,2,5,3,8,6
            for(int i = 0; i < nums.Length; i++)
            {
                if(pq.Count == k && pq.Peek() < nums[i])
                {  
                    hashSet.Add(i);
                }
                    pq.Enqueue(nums[i], nums[i]);
                    if(pq.Count > k) 
                    { 
                        pq.Dequeue(); 
                    }
              
               
                
            }

            pq.Clear();
            var count =0;
            for(int i = nums.Length - 1; i>=0; i--)
            {
                    if(pq.Count == k && pq.Peek() < nums[i]&& hashSet.Contains(i))
                    {  
                        count++;
                    }
                    pq.Enqueue(nums[i], nums[i]);
                    if(pq.Count > k) 
                    {
                        pq.Dequeue();
                    }
             
            }

            return count;
        }
    }