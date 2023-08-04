    public class Solution
    {
        public int MinFlips(string s)
        {
            var resultString = s + s; // doubled size because it is result of moving from start to end n times
           
            // there are only two possible sequences, starting with 0 and starting with 1
            // ex. s = 01010101 and s = 10101010
            var startingWithZero = CreateAlternatingBitString(resultString.Length, 0);
            var startingWithOne = CreateAlternatingBitString(resultString.Length, 1);
            var diffZero = 0;
            var diffOne = 0;
            var leftpointer = 0;
            var minFlips = int.MaxValue;
            for (int i = 0; i < resultString.Length; i++)
            {
                if (resultString[i] != startingWithZero[i])
                {
                 
                    diffZero++;
                }

                if (resultString[i] != startingWithOne[i])
                {
                    diffOne++;
                }


                // check if we are out of window
                if ((i - leftpointer) > s.Length-1)
                {
                  
                    // when moved to end of window, we need to check if we need to decrement diffZero or diffOne
                    // it will be the case when the character at left pointer is different from the character at right pointer
                    if (resultString[ leftpointer] != startingWithZero[ leftpointer])
                    {
                        diffZero--;
                    }

                    if (resultString[ leftpointer] != startingWithOne[ leftpointer])
                    {
                        diffOne--;
                    }
                      // i = right pointer
                    leftpointer++;
                }

                
                // if we reached the end of the window
                if ((i -leftpointer) == s.Length -1)
                {
                    minFlips = Math.Min(minFlips, Math.Min(diffZero, diffOne));
                }
            }

            return minFlips;
        }

        static string CreateAlternatingBitString(int n, int startingBit)
        {
            switch (startingBit)
            {
                case 1:
                    return new string(Enumerable.Range(0, n)
                        .Select(i => i % 2 == 0 ? '1' : '0')
                        .ToArray());
                case 0:
                    return new string(Enumerable.Range(0, n)
                        .Select(i => i % 2 == 0 ? '0' : '1')
                        .ToArray());
            }

            return "";
        }

    }
