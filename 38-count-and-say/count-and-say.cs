       public class Solution
       {
           private string CountAndSayCurrent(string current)
           { 
               var sb = new StringBuilder();
               var index = 0;
               while(index<current.Length)
               {
                   var count = 1;
                   while(index+1 <current.Length && current[index] == current[index+1])
                   {
                       index++;
                       count++;
                   }

                   sb.Append(count.ToString());
                   sb.Append(current[index]);
                   index++;
               }
               return sb.ToString();
           }

           public string CountAndSay(int n)
           {
               var result = "1";// base case
               for(int i = 1; i < n; i++)
               {
                   result = CountAndSayCurrent(result);
               }
               return result;
           }
       }