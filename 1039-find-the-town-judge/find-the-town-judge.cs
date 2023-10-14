 public class Solution
 {
     public int FindJudge(int n, int[][] trust)
     {
            var degreeArray= new int[n+1];
            foreach (var pair in trust)
            {
                degreeArray[pair[0]]--;
                degreeArray[pair[1]]++;
            }

            for (int i = 1; i < degreeArray.Length; i++)
            {
                if (degreeArray[i] == n - 1)
                {
                    return i;
                }
            }

            return -1;
     }
 }