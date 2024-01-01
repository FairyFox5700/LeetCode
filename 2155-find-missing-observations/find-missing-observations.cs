public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {

        var rollsSum = rolls.Count();
        var totalElCount = rollsSum + n;
        var sumToFind = (totalElCount*mean)  - rolls.Sum();

       

        if(sumToFind < n || sumToFind > n*6)
        {
            
            return new int[0];
        }

        int max = 6;
        var result = new List<int>();
        while(n!=0)
        {
            var proposedVal = sumToFind - n + 1; // max value to get to ensure that sumToFind1 > n
            var val = Math.Min(max, proposedVal);
            result.Add(val);
            sumToFind-=val;
            n--;
        }
        

        return result.ToArray();

    }
}