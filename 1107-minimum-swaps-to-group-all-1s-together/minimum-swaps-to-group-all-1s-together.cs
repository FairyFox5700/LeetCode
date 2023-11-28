    public class Solution
    {
        public int MinSwaps(int[] data)
        {
            //data = [1,0,1,0,1]
            var windowLenght = data.Sum();
            var maxCountOfOnes = int.MinValue;
            var countOfOnes = 0;
            var leftPointer = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 1)
                    countOfOnes++;
                if ((i-leftPointer+1) == windowLenght)
                {
                    maxCountOfOnes = Math.Max(maxCountOfOnes, countOfOnes);
                    if (data[leftPointer] == 1)
                        countOfOnes--;
                    leftPointer++; // shift to the right
                }
            }

            return  maxCountOfOnes == int.MinValue ? 0 : windowLenght - maxCountOfOnes;
        }
    }