    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var total = 0;
            var index = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                total+= gas[i] - cost[i];
                if (total < 0)
                {
                    //set the total to 0, to accumulate non negative values
                    total = 0;
                    index= i+1;
                }
            }

            if (gas.Sum() < cost.Sum())
            {
                return -1;
            }
            else
            {
                return index;
            }
        }
    }