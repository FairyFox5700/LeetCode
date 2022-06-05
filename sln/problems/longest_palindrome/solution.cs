public class Solution {
   public int LongestPalindrome(string s) {
        HashSet<char> mySet= new HashSet<char> ();
        var len =0;
        
        for (int i=0; i < s.Length ; i++){
            if (mySet.Contains(s[i])){
                 mySet.Remove(s[i]);
                 len += 2;
            }
            else mySet.Add(s[i]);
        }
        
        if (mySet.Count > 0)
            return len+1;
        return len;
    }
}