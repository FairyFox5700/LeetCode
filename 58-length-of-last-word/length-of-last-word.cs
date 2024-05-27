        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                var pointer  = s.Length - 1;
                while (pointer >= 0 && s[pointer] == ' ')
                {
                    pointer--;
                }
                var length = 0;
                while (pointer >= 0 && s[pointer] != ' ')
                {
                    pointer--;
                    length++;
                }

                return length;
            }
        }