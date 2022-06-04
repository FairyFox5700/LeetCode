public class Solution {
    
          private readonly Dictionary<char, int> dict = new Dictionary<char, int>{{'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}};
        public int RomanToInt(string s) {
        
        //special situation  
        s = s.Replace("IV","IIII");
        s = s.Replace("IX","VIIII");
        s = s.Replace("XL","XXXX");
        s = s.Replace("XC","LXXXX");
        s = s.Replace("CD","CCCC");
        s = s.Replace("CM","DCCCC");
        
        int result = 0;
        
        foreach(var ch in s)
        {
            result += dict[ch];
        }
        
        return result;
    }
}