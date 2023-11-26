    public class Solution
    {
        public int[] PlatesBetweenCandles(string s, int[][] queries)
        {
            //queries[i] = [lefti, righti]
            //s = "**|**|***|", queries = [[2,5],[5,9]]
            var candlesSum = new int[s.Length + 1];
            var rightMostIndexOfStick = new int[s.Length + 1];
            var leftMostIndexOfStick = new int[s.Length + 1];
            var result = new int[queries.Length];
            var items = s.ToCharArray();
            candlesSum[0] = items[0] == '*'? 1: 0;
            leftMostIndexOfStick[0]= items[0] == '*'? -1: 0;
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] == '*')
                {
                
                        candlesSum[i] += candlesSum[i - 1] + 1;
                        leftMostIndexOfStick[i] = leftMostIndexOfStick[i - 1] == -1 ? -1 : leftMostIndexOfStick[i - 1];
                }
                else
                {
                        leftMostIndexOfStick[i] = i ;
                        candlesSum[i] += candlesSum[i - 1];
                }
            }

            rightMostIndexOfStick[ s.Length - 1] = items[s.Length - 1] == '*'? -1 :  s.Length - 1;
            for (int opppositeIndex = s.Length - 2; opppositeIndex >= 0; opppositeIndex--)
            {
                if (items[opppositeIndex] == '*')
                {
                   
                    rightMostIndexOfStick[opppositeIndex] = rightMostIndexOfStick[opppositeIndex + 1] == -1
                            ? -1
                            : rightMostIndexOfStick[opppositeIndex + 1];
                }
                else
                {
                        rightMostIndexOfStick[opppositeIndex] = opppositeIndex;
                
                }
            }

            Console.WriteLine(string.Join(",", candlesSum));
            Console.WriteLine(string.Join(",", rightMostIndexOfStick));
            Console.WriteLine(string.Join(",", leftMostIndexOfStick));

            for (int i = 0; i < queries.Length; i++)
            {
                var query = queries[i];
                var left = query[0];
                var right = query[1];
                var leftIndex = leftMostIndexOfStick[right];
                var rightIndex = rightMostIndexOfStick[left];
                if (leftIndex != -1 && rightIndex != -1 && leftIndex > rightIndex)
                {
                    var leftValue = candlesSum[leftIndex];
                    var rightValue = candlesSum[rightIndex];
                    result[i] = leftValue- rightValue;
                }
            }
            return result;
        }
    }