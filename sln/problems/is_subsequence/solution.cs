    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            var left = 0;
            if(s.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (left< s.Length && s[left] == t[i])
                {
                    left++;
                }
            }

            if (left == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }