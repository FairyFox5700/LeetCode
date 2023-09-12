    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var current = new List<int>();
            var result = new List<IList<int>>();

            Backtracking(nums, 0, current,result);
            return result;
        }

        public void Backtracking(int[] nums, int start, List<int> current, List<IList<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                // choice when we added number to array
                current.Add(nums[i]);
                Backtracking(nums, i+1, current, result);
                // exclude the number from current
                current.RemoveAt(current.Count - 1);
            }
        }
    }