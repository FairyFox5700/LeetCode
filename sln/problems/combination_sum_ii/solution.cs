public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        var currentList = new List<int>();
        Array.Sort(candidates); // Sort the candidates to handle duplicates properly
        Backtracking(currentList, target, 0, candidates, result);
        return result;
    }

    public void Backtracking(List<int> currentList, int target, int startIndex, int[] candidates, List<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(currentList));
            return;
        }

        if (target < 0)
        {
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            // Skip duplicates to avoid duplicate combinations
            if (i > startIndex  && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            currentList.Add(candidates[i]);
            Backtracking(currentList, target - candidates[i], i + 1, candidates, result);
            // Backtrack to the previous state
            currentList.RemoveAt(currentList.Count - 1);
        }
    }
}
