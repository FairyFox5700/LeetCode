 public class Solution
 {
     public int[] DiStringMatch(string s)
     {
         var low = 0;
         var high = s.Length;
         var result = new int[s.Length + 1];
         for (int i = 0; i< s.Length; i++)
         {
             if (s[i] == 'I')
             {
                 
                 result[i] = low;
                 low++;
             }
             else
             {
                
                result[i] = high;
                high--;
             }
         }
         

        result[s.Length] = high;
         return result;
     }
 }