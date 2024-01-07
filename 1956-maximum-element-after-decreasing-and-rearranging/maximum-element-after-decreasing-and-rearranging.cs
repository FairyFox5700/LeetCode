    public class Solution
    {
        public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
        {
            Array.Sort(arr);//asc
            var prev = 1;
            for(int i= 1; i < arr.Length;i++)
            {
                prev = Math.Min(prev+1, arr[i]);
            }

            return prev;
        }
    }
