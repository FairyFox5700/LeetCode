public class Solution {
    public int KBigIndices(int[] nums, int k) {
        int res = 0, n = nums.Length;
        bool[] arr = new bool[n];
        PriorityQueue<int,int> pq = new();
        for(int i = 0; i < n; i++){
            if(pq.Count == k && pq.Peek() < nums[i])
                arr[i] = true;
            pq.Enqueue(nums[i], -nums[i]);
            if(pq.Count > k)
                pq.Dequeue();
        }
        pq.Clear();
        for(int i = n-1; i >= 0; i--){
            if(arr[i] && pq.Count == k && pq.Peek() < nums[i])
                res++;
            pq.Enqueue(nums[i], -nums[i]);
            if(pq.Count > k)
                pq.Dequeue();
        }
        return res;
    }
}