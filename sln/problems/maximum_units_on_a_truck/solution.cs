   public class Solution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            var sortedBoxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();
            var maxNumber = 0;
            var currentTotalNumberofBoxes = 0;
            for (int i = 0; i < sortedBoxTypes.Length; i++)
            {
                var currentBoxCount = sortedBoxTypes[i][0];
                while (currentBoxCount > 0 && currentTotalNumberofBoxes < truckSize)
                {
                    maxNumber += sortedBoxTypes[i][1] * 1;
                    currentBoxCount--;
                    currentTotalNumberofBoxes+=1;
                }
            
            }
            return maxNumber;
        }
    }