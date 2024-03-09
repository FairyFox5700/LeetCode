public class Solution
{
    public int MinOperations(int n)
    {
        int t = 0;
        while (n != 0)
        {
            int x = (int)Math.Log(n, 2);
            int dif = Math.Abs(n - (int)Math.Pow(2, x));
            int dif2 = (int)Math.Pow(2, x + 1) - n;
            n = Math.Min(dif, dif2);
            t++;
            // Console.WriteLine(n + " ");
        }
        return t;
    }
}