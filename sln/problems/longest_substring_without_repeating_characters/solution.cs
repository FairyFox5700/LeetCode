public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var l = 0;
        var hashmap = new HashSet<char>();
        var chars = s.ToCharArray();
        var max = 0;
        for(int r=0; r<s.Length; r++)
        {
            while(hashmap.Contains(chars[r]))
            {
               hashmap.Remove(chars[l]);
               l++;  
            }
            max = Math.Max(r-l+1,max);
            hashmap.Add(chars[r]);
            
        }
        return max;
    }
}