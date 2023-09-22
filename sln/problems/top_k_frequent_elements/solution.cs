    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            // 1. using a pg
            // it will be O(klogn + nlogn) , where nlogn to costruct the queue
            // and klogn to dequeue k elements
            // memory O(n)

            // 2. using bucket sort
            // it will be O(n) time and O(n) memory
            // https://www.youtube.com/watch?v=5IQrjmEJtjM&ab_channel=NeetCode

            //3. using quick select
            // it will be O(n) time and O(n) memory
            // but O(n2) in worst case

            // quick select

            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }
                dict[num]++;
            }


            var bucket = new List<int>[nums.Length + 1];
            foreach (var kvp in dict)
            {
                if (bucket[kvp.Value] == null)
                {
                    bucket[kvp.Value] = new List<int>();
                }
                bucket[kvp.Value].Add(kvp.Key);
            }

            var result = new int[k];
            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                if (bucket[i] != null)
                {
                    foreach (var val in bucket[i])
                    {
                        if (k > 0)
                        {
                            k--;
                            result[k] = val;
                        }
                    }
                }
            }

            return result;
    }
    }