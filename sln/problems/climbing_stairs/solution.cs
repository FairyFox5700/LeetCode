public class Solution {
    public int ClimbStairs(int n) 
    {
        var forOneStep = 1;
        var forTwoStep = 1;
        int sum = 0;
        // basically in each step there is a way to move 2 step oe one
        // for the last one ( only one way to reach) which is 1 step
        // for the second one from the last (also 1 step)
        // for the third one ( the sum to reach the last previos ones)
        // for the third one, is will be the sum of steps to climb first steps + 1 step
        // for the forth , the sum of three steps + one
        if(n == 1)
        {
            return 1;
        }

        // in the solution with dp
        // it will be
        // dp = [1,1]
        // dp = [2,1,1]
        // dp = [3, 2, 1, 1]
        // dp = [4, 3, 2, 1, 1]
        for(int i = n-1; i > 0; i --)
        {
            sum = forOneStep + forTwoStep;
            forTwoStep = forOneStep;
            forOneStep = sum;
        }
        return sum;
    }
}