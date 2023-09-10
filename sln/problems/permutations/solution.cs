    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var currentList = new List<int>();
            var hashSetOfUsedIndexes = new HashSet<int>();
            Backtracking(currentList,hashSetOfUsedIndexes, nums, result);
            return result;

        }

        public void Backtracking(List<int> currentList, HashSet<int> hashSetOfUsedIndexes, int[] nums,
            List<IList<int>> result)
        {

            if (currentList.Count == nums.Length)
            {
                result.Add(new List<int>(currentList));
                currentList = new List<int>();
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSetOfUsedIndexes.Contains(i))
                {
                    hashSetOfUsedIndexes.Add(i);
                    currentList.Add(nums[i]);
                    Backtracking(currentList, hashSetOfUsedIndexes, nums, result);
                    // backtrack to previous after reaching the end of chain
                    hashSetOfUsedIndexes.Remove(i);
                    currentList.Remove(nums[i]);
                }
            }
        }
    }