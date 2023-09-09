    public class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            var left = 1;
            var right = piles.Max();
            var result = 0;
            while (left <= right)
            {
                // we trying to find the best h
                // we have an available number of hours to eat piles of fruits
                // we start from the middle
                // the k value varies from 1 to max(piles)
                // if we were able to eat all bananas with speed k, then we can select a smaller value
                var mid = left + (right - left) / 2;
                // how to calcuate number of hours to eat each pile
                // if mid is speed
                // then i/mid is the number of hours to eat each pile
                // and we sum up all the hours
                var sum = 0d;
                for (int i = 0; i < piles.Length; i++)
                {
                   sum += Math.Ceiling((double)piles[i] / mid);
                }

                if (sum <= h)
                {
                    right = mid - 1;
                    result = mid;
                }
                else
                {
                    left = mid + 1;
                }

                
            }

            return result;
        }
    }
