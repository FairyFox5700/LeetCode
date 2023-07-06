public class Solution {
    public int MinCostClimbingStairs(int[] cost) 
    {
        var arrayOfTotalCost = new int[cost.Count()];
        arrayOfTotalCost[0] =cost[0];
        arrayOfTotalCost[1] =cost[1];
        for(int i = 2; i < cost.Count(); i++)
        {
            // cost for the third= cost of jumping to the first + previous cost
            // or jump to the second one and totalcost of second
            // in case of 1 and 100, if we select 100 instead of 1, the result will be maximum, because we have non negative values
            arrayOfTotalCost[i] =cost[i] + Math.Min(arrayOfTotalCost[i-1],arrayOfTotalCost[i-2]);
        }

        return Math.Min( arrayOfTotalCost[cost.Count()-2],  arrayOfTotalCost[cost.Count()-1]);
    }
}