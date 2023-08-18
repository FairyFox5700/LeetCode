    public class Solution
    {
                public string LongestPalindrome(string s)
        {
            //https://leetcode.com/problems/longest-palindromic-substring/solutions/3911431/python-beats-95-expanding-around-centers-approach-explained/ -- explanation
            var maxLength = 0;
        var maxLengthStr= new ReadOnlySpan<char>();

        for (int i = 0; i < s.Length; i++)
        {
            int left = i; int right = i;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                    maxLengthStr = s.AsSpan(left, maxLength);
                }
                left--;
                right++;
            }
            left = i; right = i+1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                    maxLengthStr = s.AsSpan(left, maxLength);
                }
                left--;
                right++;
            }

        }
        return maxLengthStr.ToString();
        }

    }