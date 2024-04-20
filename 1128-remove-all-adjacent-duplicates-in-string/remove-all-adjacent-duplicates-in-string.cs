public class Solution {
    public string RemoveDuplicates(string s) 
    {
        var sb = new StringBuilder();
        for(int i=0; i< s.Length; i++)
        {
            if(sb.Length != 0 && sb[sb.Length -1] == s[i] )
            {
                  sb.Remove(sb.Length -1,1);
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        
        return sb.ToString();
    }
}