    public class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>();
            var currentList = new List<int>();
            var hashSetOfUsedIndexes = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (hashSetOfUsedIndexes.ContainsKey(num))
                {
                    hashSetOfUsedIndexes[num]++;
                }
                else
                {
                    hashSetOfUsedIndexes.Add(num, 1);
                }
            }
            Backtracking(currentList, hashSetOfUsedIndexes, nums, result);
            return result;

        }

        public void Backtracking(List<int> currentList, Dictionary<int,int> hashSetOfUsedIndexes, int[] nums,
            List<IList<int>> result)
        {

            if (currentList.Count == nums.Length)
            {
                result.Add(new List<int>(currentList));
                currentList = new List<int>();
                return;
            }

            //instead of all possible choices we consider only unique ones
            foreach (var (key, val) in hashSetOfUsedIndexes)
            {
                if (val > 0)
                {
                    // it is still available
                    hashSetOfUsedIndexes[key]--;
                    currentList.Add(key);

                    Backtracking(currentList, hashSetOfUsedIndexes, nums, result);

                    hashSetOfUsedIndexes[key]++;
                    currentList.RemoveAt(currentList.Count - 1);

                }
            }
        }
    }