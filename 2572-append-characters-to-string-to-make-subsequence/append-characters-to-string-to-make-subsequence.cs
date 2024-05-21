    public class Solution
    {
        public int AppendCharacters(string s, string t)
        {
            var sIndex = 0;
            var tIndex = 0;
            var moves = 0;
            while(sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                    tIndex++;
                }
                else
                {
                    sIndex++;
                }
            }
            // now s index is at the end of s
            // if t index is at the end of s, then we can append the characters
            moves +=t.Length - tIndex;

            return moves;
        }
    }