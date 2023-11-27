public class Solution {


        public int PartitionString(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int result = 1;

            var chars = new HashSet<char>();

            foreach (var c in s)
            {
                if (chars.Contains(c))
                {
                    result++;
                    chars = new HashSet<char>() { c };

                }
                else
                {
                    chars.Add(c);
                }
            }

            return result;
        }
}