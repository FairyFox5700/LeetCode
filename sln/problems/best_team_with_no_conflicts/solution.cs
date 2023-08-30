 public class Solution
 {
        public int BestTeamScore(int[] scores, int[] ages)
        {
           var tuples = ages.Zip(scores,(a,s)=> (Age: a, Score: s))
               .OrderBy(p=>p.Age)
               .ThenBy(s=>s.Score)
               .ToArray();

            // scores = [6,5,4,5], ages = [2,1,2,1]
            // (1,5), (1,5), (2,6), (2,4)
            // after then by by score
            // (1,5), (1,5), (2,4), (2,6)

            var dp = new int[tuples.Length];
           // initially will be set to the score of the player
           for (int i = 0; i < tuples.Length; i++)
           {
                dp[i] = tuples[i].Score;
           }

           for (int i = 0; i < tuples.Length; i++)
           {
               var currentPlayer = tuples[i];
               for (int j = i-1; j>=0; j--)
               {
                    var previousPlayer = tuples[j];
                    // previous player alway youunger, so the score should be strictly less then the current player
                    if (previousPlayer.Score <= currentPlayer.Score)
                        dp[i] = Math.Max(dp[i], dp[j] + currentPlayer.Score);
                    else
                    {
                        // do not include the current player
                        dp[i] = dp[i];
                    }
               }
           }

           return dp.Max();
        }
    }