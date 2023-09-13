    public class Solution
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var result = new List<IList<int>>();
            var currentList = new List<int>();
            Backtracking(currentList, k,n, 1, result);
            return result;
        }

        public void Backtracking(List<int> currentList, int size,int target, int startIndex, List<IList<int>> result)
        {
            if (target == 0 && currentList.Count == size)
            {
                result.Add(new List<int>(currentList));
                return;
            }

            if (target < 0 || currentList.Count > size)
            {
                return;
            }
            for (int i = startIndex; i <= 9; i++)
            {
                currentList.Add(i);
                Backtracking(currentList, size, target - i, i + 1,  result);
                // Backtrack to the previous state
                currentList.RemoveAt(currentList.Count - 1);
            }
        }
    }