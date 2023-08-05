    public class Solution
    {

        /*
        Greedy Strategy:
Sort both the arrays g[] and s[] in ascending order. Start iterating through the sorted arrays, and for each child, try to find the smallest cookie that can satisfy their greed factor. If such a cookie exists, assign it to the child and move on. If not, move to the next child.
*/
        public int FindContentChildren(int[] g, int[] s)
        {
            if(g.Length == 0 || s.Length == 0) return 0;
            var kids = g.OrderBy(x => x).ToArray();
            var cookies = s.OrderBy(x => x).ToArray();

            var ans  = 0;
            var currentCookie = 0;
            for (int i = 0; i < kids.Length; i++)
            {
                // we tend to give the smallest cookie to the smallest kid
                while (currentCookie < cookies.Length)
                {
                    if (cookies[currentCookie] >= kids[i])
                    {
                        ans++;
                        currentCookie++;
                        break;
                    }
                    else{
                         currentCookie++;
                    }
                }
            }

            return ans;
        }
    }