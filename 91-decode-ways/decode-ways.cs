public class Solution
{
    public int NumDecodings(string s)
    {
        if (s == null || s.Length == 0 || s[0] == '0') return 0;

        var decodings = new int[s.Length + 1];
        decodings[0] = 1; // Base case: empty string has 1 way to decode
        decodings[1] = s[0] != '0' ? 1 : 0; // Base case: the first char can be decoded in 1 way if it's not '0'

        for (int i = 2; i <= s.Length; i++)
        {
            int oneDigit = int.Parse(s.Substring(i - 1, 1));
            int twoDigits = int.Parse(s.Substring(i - 2, 2));

            // Single digit decoding (from '1' to '9')
            if (oneDigit >= 1)
            {
                decodings[i] += decodings[i - 1];
            }

            // Two digits decoding (from '10' to '26')
            if (twoDigits >= 10 && twoDigits <= 26)
            {
                decodings[i] += decodings[i - 2];
            }
        }

        return decodings[s.Length];
    }
}
