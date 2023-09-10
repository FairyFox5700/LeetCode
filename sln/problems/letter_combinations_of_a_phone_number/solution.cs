    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            var currentList = new List<char>();
            var dict = new Dictionary<int, List<char>>()
            {
                {1, new List<char>() { }},
                {2, new List<char>() { 'a', 'b', 'c' }},
                {3, new List<char>() { 'd', 'e', 'f' }},
                {4, new List<char>() { 'g', 'h', 'i' }},
                {5, new List<char>() { 'j', 'k', 'l' }},
                {6, new List<char>() { 'm', 'n', 'o' }},
                {7, new List<char>() { 'p', 'q', 'r', 's' }},
                {8, new List<char>() { 't', 'u', 'v' }},
                {9, new List<char>() { 'w', 'x', 'y', 'z' }},
            };

            Combinations(dict, currentList, 0,  digits.Select(e=> e- '0').ToList(), result);
            return  result;
        }

        public void Combinations(Dictionary<int, List<char>> dict, List<char> current, int startIndex, List<int> digits, List<string> result)
        {
            //chaList.Count equeals digits count
            if (current.Count == digits.Count)
            {
                var data = new string(current.ToArray());
                if(data != string.Empty)
                    result.Add(data);
                return;
            }

            if (startIndex >= dict.Count)
            {
                return;
            }
            //23
            for (int i = startIndex; i < digits.Count; i++)
            {
                var list = dict[digits[i]];
                foreach (var ch in list)
                {
                    current.Add(ch);
                    Combinations(dict,current, i+1,digits, result);
                    current.RemoveAt(current.Count -1);
                }
            }
        }
    }