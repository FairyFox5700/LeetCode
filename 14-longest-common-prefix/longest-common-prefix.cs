    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                var c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                    {

                        // the min length when the character become diffrent
                        return strs[0].Substring(0, i);
                    }
                }
            }

            // worst case O (n * m) where n is the length of the array and m is the length of the string
            // best case O (m) where m is the length of the string
            // avarage case O (n * Min(m)) where n is the length of the array and m is the length of the string
            return strs[0];
        }
    }