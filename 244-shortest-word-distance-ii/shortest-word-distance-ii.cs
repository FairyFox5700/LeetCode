public class WordDistance {


    private Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
    public WordDistance(string[] wordsDict) {
        
        for(int i = 0; i < wordsDict.Length; i++)
        {
            if(dict.ContainsKey(wordsDict[i]))
            {
                dict[wordsDict[i]].Add(i);
            }
            else
            {
                dict.Add(wordsDict[i], new List<int>(){i});
            }
        }
    }
    
    public int Shortest(string word1, string word2) {
        dict.TryGetValue(word1, out List<int> list1);
        dict.TryGetValue(word2, out List<int> list2);

        if(list1.Count == 0 || list2.Count == 0)
        {
            return -1;
        }

        var min = int.MaxValue;
        var w1Index = 0;
        var w2Index = 0;
        while(w1Index < list1.Count && w2Index < list2.Count)
        {
            min = Math.Min(min, Math.Abs(list1[w1Index] - list2[w2Index]));
            if(list1[w1Index] < list2[w2Index])
            {
                w1Index++;
            }
            else
            {
                w2Index++;
            }
        }

        return min;
    }
}

/**
 * Your WordDistance object will be instantiated and called as such:
 * WordDistance obj = new WordDistance(wordsDict);
 * int param_1 = obj.Shortest(word1,word2);
 */