    public class Solution
    {
        public bool CanMakeSubsequence(string str1, string str2)
        {
            var str1Index = 0;
            var str2Index = 0;
            //  str1 = "abc", str2 = "ad"
            while(str1Index < str1.Length)
            {
                if (str1Index < str1.Length && str2Index < str2.Length && (
                    str1[str1Index] == str2[str2Index] || str1[str1Index] == Roll(str2[str2Index])))
                {
                    str1Index++;
                    str2Index++;
                }
                else
                {
                    str1Index++;
                }
            }
            return str2Index == str2.Length;
        }

        private char Roll(char c)
        {
            if(c == 'a')
                return 'z';
            else
            {
                return (char)((int)c - 1);
            }
        }
    }