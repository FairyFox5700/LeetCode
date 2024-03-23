
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var dict = new HashSet<string>(wordList);
        if (!dict.Contains(endWord))
        {
            return 0;
        }

        var queue = new Queue<string>();
        var visited = new HashSet<string>();
        queue.Enqueue(beginWord);
        visited.Add(beginWord);

        // generate all possible words
        var possibleWordTransformations = new Dictionary<string, List<string>>();

        foreach (var word in wordList)
        {
            for (int ch = 0; ch < word.Length; ch++)
            {
                var transformation = word.Substring(0, ch) + '*' + word.Substring(ch + 1);
                if (!possibleWordTransformations.ContainsKey(transformation))
                {
                    possibleWordTransformations[transformation] = new List<string>();
                }
                possibleWordTransformations[transformation].Add(word);
            }
        }

        var level = 1;
        while (queue.Count > 0)
        {
            var levelLength = queue.Count;
            for (int i = 0; i < levelLength; i++)
            {
                var currentWord = queue.Dequeue();
                if (currentWord == endWord)
                {
                    return level;
                }
                for (int ch = 0; ch < currentWord.Length; ch++)
                {
                    var transformation = currentWord.Substring(0, ch) + '*' + currentWord.Substring(ch + 1);
                    var words = possibleWordTransformations.GetValueOrDefault(transformation, new List<string>());
                    foreach (var word in words)
                    {
                        if (!visited.Contains(word))
                        {
                            visited.Add(word);
                            queue.Enqueue(word);
                        }
                    }
                }
            }
            level++;
        }

        return 0;
    }
}
