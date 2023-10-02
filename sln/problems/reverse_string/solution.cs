 public class Solution
    {
       //https://github.com/akhilkammila/leetcode-screenshotter/blob/main/editorial-screenshots/1-999/344.%20Reverse%20String.png
        public void ReverseString(char[] s)
        {
           var left = 0;
           var right = s.Length - 1;
           while (left < right)
           {
                (s[left], s[right]) = (s[right], s[left]);
                left++;
                right--;
           }
        }
    }