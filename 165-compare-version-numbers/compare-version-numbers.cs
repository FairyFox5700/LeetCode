public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        int pointer1 = 0;
        int pointer2 = 0;

        while (pointer1 < version1.Length || pointer2 < version2.Length)
        {
            int v1 = 0;
            int v2 = 0;

            // Parse segment from version1
            while (pointer1 < version1.Length && version1[pointer1] != '.')
            {
                v1 = v1 * 10 + (version1[pointer1] - '0');
                pointer1++;
            }

            // Parse segment from version2
            while (pointer2 < version2.Length && version2[pointer2] != '.')
            {
                v2 = v2 * 10 + (version2[pointer2] - '0');
                pointer2++;
            }

            if (v1 > v2)
            {
                return 1;
            }
            else if (v1 < v2)
            {
                return -1;
            }

            // Move pointers past the dot (if there is one)
            if (pointer1 < version1.Length && version1[pointer1] == '.')
            {
                pointer1++;
            }
            if (pointer2 < version2.Length && version2[pointer2] == '.')
            {
                pointer2++;
            }
        }

        return 0;
    }
}
