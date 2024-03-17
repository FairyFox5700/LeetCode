public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length != word2.Length)
            return false;
        var wordmap1 = new int[26];
        var wordmap2 = new int[26];

        foreach(var ch in word1)
        {
            wordmap1[ch-'a']++;
        }

        foreach(var ch in word2)
        {
            wordmap2[ch-'a']++;
        }

        for(int i = 0; i<26; i++)
        {
            if(wordmap1[i] == 0 && wordmap2[i]>0)
                return false;
            if(wordmap2[i] == 0 && wordmap1[i]>0)
                return false;
        }

        Array.Sort(wordmap1);
        Array.Sort(wordmap2);

        return wordmap1.SequenceEqual(wordmap2);

    }
}