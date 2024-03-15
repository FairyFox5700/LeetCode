public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var sToT = new Dictionary<char, char>();
        var tToS = new Dictionary<char, char>();

        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            char sChar = s[i];
            char tChar = t[i];

            // Check if the mapping exists in sToT
            if (sToT.ContainsKey(sChar))
            {
                if (sToT[sChar] != tChar)
                {
                    return false;
                }
            }
            else
            {
                sToT[sChar] = tChar;
            }

            // Check if the mapping exists in tToS
            if (tToS.ContainsKey(tChar))
            {
                if (tToS[tChar] != sChar)
                {
                    return false;
                }
            }
            else
            {
                tToS[tChar] = sChar;
            }
        }

        return true;
    }
}
