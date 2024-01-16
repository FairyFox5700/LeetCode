public class Solution
{
    public string ShortestBeautifulSubstring(string s, int k)
    {
        var left = 0;
        var min = int.MaxValue;
        var oneCount = 0;
        var result = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                oneCount++;
            }

            while (oneCount == k)
            {
                var newLength = i - left + 1;

                if (newLength < min)
                {
                    min = newLength;
                    result = new List<string>();
                    var newStr = s.Substring(left, min);
                    result.Add(newStr);
                }
                else if (newLength == min)
                {
                    var newStr = s.Substring(left, min);
                    result.Add(newStr);
                }

                if (s[left] == '1')
                {
                    oneCount--;
                }
                left++;
            }
        }

        Console.WriteLine(result.Count());
        return min == int.MaxValue ? "" : result.OrderBy(e => e).First();
    }
}
