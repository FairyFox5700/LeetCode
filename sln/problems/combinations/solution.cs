    public class Solution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();
            var currentList = new List<int>();
            var hashSetOfUsedIndexes = new HashSet<int>();
            Backtracking(currentList, k, 1, n,result);
            return result;

        }

        public void Backtracking(List<int> currentList, int k, int startIndex, int n,
            List<IList<int>> result)
        {

            if (currentList.Count == k)
            {
                result.Add(new List<int>(currentList));
                return;
            }

            for (int i = startIndex; i <= n; i++)
            {
                currentList.Add(i);
                Backtracking(currentList,  k, i + 1, n, result);
                // backtrack to previous after reaching the end of chain
                currentList.Remove(i);
            }
        }
    }

    // trace
    // backtracking([],2, 1, 4, result)
    // backtracking([1],2, 2, 4, result) -- this line to pop, index = 2
    // backtracking([1,2],2, 3, 4, result)
    // pop 2
    // currentList = [1]
    // continue loop with i = 3 (as it was increased)
    // backtracking([1, 3],2, 4, 4, result)
    // pop 3
    // currentList = [1]
    // continue loop with i = 4 (as it was increased)
    // backtracking([1, 4],2, 5, 4, result)
    // pop 4
    // currentList = [1]
    // lop has finished, backtracking
    // pop 1
    // currentList = []
    // index = 2 (after poping)
    // continue loop with i = 2 (as it was increased)
    // backtracking([2],2, 3, 4, result)
    // backtracking([2,3],2, 4, 4, result)
    // pop 3
    // currentList = [2]
    // continue loop with i = 4 (as it was increased)
    // backtracking([2,4],2, 5, 4, result)
    // pop 4
    // currentList = [2]
    // lop has finished, backtracking
    // pop 2
    // currentList = []
    // index = 3 (after poping)
    // continue loop with i = 3 (as it was increased)
    // backtracking([3],2, 4, 4, result)
    // backtracking([3,4],2, 5, 4, result)
    // pop 4
    // currentList = [3]
    // lop has finished, backtracking
    // pop 3
    // currentList = []
    // index = 4 (after poping)
    // continue loop with i = 4 (as it was increased)
    // backtracking([4],2, 5, 4, result)
    // pop 4
    // currentList = []
    // lop has finished, backtracking
