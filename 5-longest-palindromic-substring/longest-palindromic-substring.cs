 public class Solution
    {
        public string LongestPalindrome(string s)
        {
              if (string.IsNullOrEmpty(s)) // Check for empty input
            return "";
              var maxLength = 1;
                var start = 0;

            var dp = new bool[s.Length, s.Length];
       
            // vase case: all substrings of length 1 are palindromes

            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = true; // feel diagonal
          
            }

            // base case 2: all substrings of lenght 2 are palindromes if they are the same character
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    dp[i, i + 1] = true;
                     maxLength = 2;
                    start = i;
                }
            }

            // dp = [1, 0, 0, 0, 0]
            //      [0, 1, 0, 0, 0]
            //      [0, 0, 1, 0, 0]
            //      [0, 0, 0, 1, 0]
            //      [0, 0, 0, 0, 1]

            // for the length of 3 and more
            // it is a substring, if boundary elements are equal and the inner substring is also a palindrome

            for (int len = 2; len <= s.Length; len++)
            {
                for (int j = 0; j < s.Length-len; j++)
                {
                    var currentIndex = j+len; // current index of length len
                    // boundaries are equal
                    if (s[currentIndex] == s[j])
                    {
                        // check internal state
                        var internal1 = dp[j+1, currentIndex-1]; // for 2; slice from dp[2, 1] string of lenght 2, that start at 1 and is length of 2
                        dp[j, currentIndex] = internal1;
                        if (len+1 > maxLength && internal1)
                        {
                            maxLength = len+1;
                            start = j;
                        }
                    }
                }
            }

            return s.Substring(start, maxLength);

            // len = 3
            // dp = [1, 0, 1, 1, 0]
            //      [0, 1, 0, 0, 1]
            //      [0, 0, 1, 0, 0]
            //      [0, 0, 0, 1, 0]
            //      [0, 0, 0, 0, 1]
        }
    }

/*
    
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

    */