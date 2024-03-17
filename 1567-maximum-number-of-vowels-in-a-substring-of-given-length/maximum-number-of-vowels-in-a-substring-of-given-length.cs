public class Solution {
    public int MaxVowels(string s, int k) {
        // Define vowels
        HashSet<char> vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
        
        int maxVowels = 0;
        int currentVowels = 0;
        
        maxVowels = currentVowels;
        
        // Slide the window through the string
        for (int i = 0; i < s.Length; i++) {
            // Update currentVowels count for the new character entering the window
            if (vowels.Contains(s[i])) {
                currentVowels++;
            }
            
            if(i>=k)
            {

            
            // Update currentVowels count for the character leaving the window
            if (vowels.Contains(s[i - k])) {
                currentVowels--;
            }
            }
            
            // Update maxVowels if necessary
            maxVowels = Math.Max(maxVowels, currentVowels);
        }
        
        return maxVowels;
    }
}
