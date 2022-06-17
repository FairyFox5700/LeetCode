public class Solution {
    public string LongestPalindrome(string s) {
        if(s=="" || s.Length<=1)
            return s;
        int length = 0, start = 0;
        for(int i=0; i<s.Length; i++)
        {
            int evenLength = PalindromeLength(s, i, i+1);
            int oddLength = PalindromeLength(s, i, i);
            int currentLength = Math.Max(evenLength, oddLength);
            
            if(currentLength>length)
            {
                length = currentLength;
                start = i-(length-1)/2;
            }
        }
        
        return s.Substring(start, length);
    }
    
    private int PalindromeLength(string s, int left, int right){
        while(left>=0 && right<s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right-left-1; // (right+1) - (left-1) - 1
    }
}