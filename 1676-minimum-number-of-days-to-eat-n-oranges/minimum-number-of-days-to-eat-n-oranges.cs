    public class Solution
    {
    private Dictionary<int, int> memo;

    public int MinDays(int n)
    {
        memo = new Dictionary<int, int>();
        return Numbers(n);
    }

    private int Numbers(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        if (memo.ContainsKey(n)) return memo[n];

        // Calculate steps, including the division and handling remainder in one step
        int stepsWhenDivBy2 = 1 + n % 2 + Numbers(n / 2); // 1 day for operation + remainder + recursive steps
        int stepsWhenDivBy3 = 1 + n % 3 + Numbers(n / 3); // 1 day for operation + remainder + recursive steps

        // Store the result in the dictionary
        memo[n] = Math.Min(stepsWhenDivBy2, stepsWhenDivBy3);
        return memo[n];
    }

        /*private int Numbers(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            if (memo[n] != 0)
                return memo[n];

            var min2 = int.MaxValue;
            var min3 = int.MaxValue;

            if (n % 2 == 0)
                min2 = 1 + Numbers(n / 2);

            if (n % 3 == 0)
                min3 = 1 + Numbers(n / 3);

            var min1 = 1 + Numbers(n - 1);

            memo[n] = Math.Min(min1, Math.Min(min2, min3));
            Console.WriteLine("n: " + n + ", memo: " + memo[n]);

            return memo[n];
        }*/
    }
