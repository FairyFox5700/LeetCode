    public class Solution
    {
        public int MostExpensiveItem(int primeOne, int primeTwo)
        {
            // 5 7
            // 5
            // 7
            // 5*5 = 25
            // 7*5 = 35
            // i, i+priceItem1 , i+priceItem2
            // dp = []
            //1,
            //2
            //3
            //4
            //5
            // 5+priceItem1 = 10, 5+priceItem2 = 27

            var dp = new bool[primeOne * primeTwo];
            dp[primeOne] = true;
            dp[primeTwo] = true;

            for (int i = Math.Min(primeOne, primeTwo); i < dp.Length; i++)
            {
                if (dp[i])
                {
                    var index1 = Math.Min(primeOne + i, dp.Length - 1);
                    var index2 = Math.Min(primeTwo + i, dp.Length - 1);
                    dp[index1] = true;
                    dp[index2] = true;
                }
        }
            return dp
                .Select((value, index) => new { Index = index, Value = value })
                .Where(x => x.Value == false)
                .Select(x => x.Index) // Only return the index
                .Last(); // Return the last index where the value is false
        }
    }