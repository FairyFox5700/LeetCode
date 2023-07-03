public class Solution {
    public int LongestPalindrome(string s) {
        var temp = s.ToCharArray();
        var dict = new Dictionary<char, int>();
        for(int i= 0; i< temp.Count(); i++)
        {
            if(dict.ContainsKey(temp[i]))
            {
                dict[temp[i]]++;
            }
            else
            {
                dict.Add(temp[i], 1);
            }
        }
        var result = 0;
        int c = 0;
        foreach(var val in dict.Values)
        {
            int remainder = val % 2;
            if(val % 2 == 0)
            {
                result += val;
            }
            else
            {
                var div = val / 2;
                result  += val -remainder;
                c = 1;
            }
            
        }
        return result + c;
    }
}