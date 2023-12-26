public class Solution {
           public int MaxNumberOfBalloons(string text)
           {
               var word = "balloon";
               var patternFreq = new int[26];
               for (int i = 0; i < word.Length; i++)
               {
                   patternFreq[word[i] - 'a']++;
               }

               var textFreq = new int[26];
               for(int i = 0;i < text.Length;i++)
               {
                   textFreq[text[i] - 'a']++;
               }


               // find min
               var min = int.MaxValue;
               for (int i = 0;i<26;i++)
               {
                   if (patternFreq[i] >0 )
                   {

                       min = Math.Min((int)textFreq[i] / (int)patternFreq[i], min);
                   }
               }

               return min;
           }
}