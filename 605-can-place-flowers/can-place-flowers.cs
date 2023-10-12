    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
            {
                return true;
            }
         

            for (int i = 0; i < flowerbed.Length ; i++)
            {
         
                if (flowerbed[i] == 0)
                {
                    //first case
                    var prev = (i == 0 || flowerbed[i - 1] == 0);
                    var next = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                    if (prev && next)
                    {
                        n--;
                        flowerbed[i] = 1;
                               if (n <= 0)
                {
                    return true;
                }

                    }
                }
            }

            return false;
        }
    }